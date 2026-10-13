'NG ZHENG KAI - A25DW0669 (Section J1)
Imports MySql.Data.MySqlClient

Public Class LoginForm

    Public Event LoginRequested(
        ByVal role As String,
        ByVal username As String,
        ByVal password As String
    )
#Region "Function"
    Private selectedRole As String = "Student"

    Private Sub LoginForm_Load(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles MyBase.Load

        Me.CancelButton = Nothing
        txtPassword.UseSystemPasswordChar = True

        SetLoginRole("Student")
        txtEmail.Focus()

    End Sub

    Private Sub SetLoginRole(ByVal role As String)

        selectedRole = role

        txtEmail.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False

        If selectedRole = "Admin" Then

            lblTitle.Text = "Admin Login"
            lblUsername.Text = "Admin Name"
            lblSubtitle.Text =
                "Sign in to continue to the admin dashboard."

            lnkAdminLogin.Text = "Back to Student Login"
            btnRegister.Visible = False

        Else

            lblTitle.Text = "Student Login"
            lblUsername.Text = "Student Email"
            lblSubtitle.Text =
                "Sign in to continue to your library account."

            lnkAdminLogin.Text = "Admin Login"
            btnRegister.Visible = True

        End If

        txtEmail.Focus()

    End Sub

    Private Sub lnkAdminLogin_LinkClicked(
        ByVal sender As System.Object,
        ByVal e As LinkLabelLinkClickedEventArgs
    ) Handles lnkAdminLogin.LinkClicked

        If selectedRole = "Admin" Then
            SetLoginRole("Student")
        Else
            SetLoginRole("Admin")
        End If

    End Sub
#End Region

#Region "Check Password"
    Private Sub chkShowPassword_CheckedChanged(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked

    End Sub
#End Region

#Region "Button"
    Private Sub btnLogin_Click(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles btnLogin.Click

        Dim username As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = String.Empty Then

            If selectedRole = "Admin" Then

                MessageBox.Show(
                    "Please enter your admin name.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else

                MessageBox.Show(
                    "Please enter your student email.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If

            txtEmail.Focus()
            Return

        End If

        If password = String.Empty Then

            MessageBox.Show(
                "Please enter your password.",
                "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Focus()
            Return

        End If

        Try

            Dim loginSuccessful As Boolean = False

            ClearSession()

            Using conn As MySqlConnection = GetConnection()

                conn.Open()

                Dim sql As String

                If selectedRole = "Admin" Then

                    sql =
                        "SELECT admin_ID, admin_Name " &
                        "FROM admin " &
                        "WHERE admin_Name = @username " &
                        "AND admin_password = @password " &
                        "LIMIT 1"

                Else

                    sql =
                        "SELECT stu_ID, stu_name, admin_ID " &
                        "FROM student " &
                        "WHERE email = @username " &
                        "AND stu_password = @password " &
                        "LIMIT 1"

                End If

                Using cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "@username",
                        username
                    )

                    cmd.Parameters.AddWithValue(
                        "@password",
                        password
                    )

                    Using reader As MySqlDataReader =
                        cmd.ExecuteReader()

                        If reader.Read() Then

                            CurrentRole = selectedRole

                            If selectedRole = "Admin" Then

                                CurrentUserID =
                                    Convert.ToInt32(
                                        reader("admin_ID")
                                    )

                                CurrentAdminID =
                                    CurrentUserID

                                CurrentUserName =
                                    reader("admin_Name").ToString()

                                CurrentUserEmail =
                                    String.Empty

                            Else

                                CurrentUserID =
                                    Convert.ToInt32(
                                        reader("stu_ID")
                                    )

                                CurrentUserName =
                                    reader("stu_name").ToString()

                                CurrentUserEmail =
                                    username

                                If Not Convert.IsDBNull(
                                    reader("admin_ID")
                                ) Then

                                    CurrentAdminID =
                                        Convert.ToInt32(
                                            reader("admin_ID")
                                        )

                                Else

                                    CurrentAdminID = 0

                                End If

                            End If

                            loginSuccessful = True

                        End If

                    End Using

                End Using

            End Using

            If loginSuccessful Then

                RaiseEvent LoginRequested(
                    selectedRole,
                    username,
                    password
                )

                If selectedRole = "Student" Then

                    Me.Hide()

                    Using frmStudent As New StudentForm()
                        frmStudent.ShowDialog()
                    End Using

                    ClearSession()
                    SetLoginRole("Student")
                    Me.Show()

                Else
                    Using frmAdmin As New AdminDashboard
                        frmAdmin.ShowDialog()
                    End Using
                    ClearSession()
                    SetLoginRole("Admin")
                    Me.Show()


                End If

            Else

                MessageBox.Show(
                    "Invalid username/email or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()

            End If

        Catch ex As MySqlException

            MessageBox.Show(
                "Database error:" &
                Environment.NewLine &
                ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnRegister_Click(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles btnRegister.Click

        Using frm As New RegisterForm()
            frm.ShowDialog()
        End Using

    End Sub
#End Region
End Class