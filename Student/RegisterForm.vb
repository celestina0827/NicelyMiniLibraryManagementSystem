'NG ZHENG KAI - A25DW0669 (Section J1)
Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Public Event RegisterRequested(
        ByVal studentID As Integer,
        ByVal studentName As String,
        ByVal email As String,
        ByVal password As String
    )
#Region "Form Load & Initialization"
    Private Sub RegisterForm_Load(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

        lblStatus.Text = String.Empty
        Me.AcceptButton = btnRegister

        txtStuID.Focus()

    End Sub
#End Region

#Region "Password Visibility"
    Private Sub chkShowPassword_CheckedChanged(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked

        txtConfirmPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked

    End Sub
#End Region

#Region "Registration"

    Private Sub btnRegister_Click(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles btnRegister.Click

        lblStatus.ForeColor = Color.Firebrick
        lblStatus.Text = String.Empty

        Dim studentID As Integer
        Dim studentName As String = txtStuName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text

        'Check Student ID
        If Not Integer.TryParse(txtStuID.Text.Trim(), studentID) _
            OrElse studentID <= 0 Then

            lblStatus.Text =
                "Student ID must be a positive number."

            txtStuID.Focus()
            Return
        End If

        'Check Student Name
        If studentName = String.Empty Then
            lblStatus.Text =
                "Please enter the student name."

            txtStuName.Focus()
            Return
        End If

        'Check Email
        If email = String.Empty OrElse Not email.Contains("@") Then
            lblStatus.Text =
                "Please enter a valid email address."

            txtEmail.Focus()
            Return
        End If

        'Check Password
        If password.Length < 6 Then
            lblStatus.Text =
                "Password must contain at least 6 characters."

            txtPassword.Focus()
            Return
        End If

        'double check password
        If password <> txtConfirmPassword.Text Then
            lblStatus.Text =
                "The passwords do not match."

            txtConfirmPassword.Focus()
            Return
        End If

        Try
            Using connection As MySqlConnection =
                DBConnection.GetConnection()

                connection.Open()

                'check Student ID or Email already exists
                Dim checkSql As String =
                    "SELECT COUNT(*) FROM student " &
                    "WHERE stu_ID = @stuID OR email = @email"

                Using checkCommand As New MySqlCommand(
                    checkSql,
                    connection
                )

                    checkCommand.Parameters.Add(
                        "@stuID",
                        MySqlDbType.Int32
                    ).Value = studentID

                    checkCommand.Parameters.Add(
                        "@email",
                        MySqlDbType.VarChar,
                        100
                    ).Value = email

                    Dim existingCount As Integer =
                        Convert.ToInt32(
                            checkCommand.ExecuteScalar()
                        )

                    If existingCount > 0 Then
                        lblStatus.Text =
                            "Student ID or email already exists."

                        Return
                    End If

                End Using

                'add student information
                'admin_ID NULL
                Dim insertSql As String =
                    "INSERT INTO student " &
                    "(stu_ID, stu_name, email, stu_password) " &
                    "VALUES " &
                    "(@stuID, @stuName, @email, @password)"

                Using insertCommand As New MySqlCommand(
                    insertSql,
                    connection
                )

                    insertCommand.Parameters.Add(
                        "@stuID",
                        MySqlDbType.Int32
                    ).Value = studentID

                    insertCommand.Parameters.Add(
                        "@stuName",
                        MySqlDbType.VarChar,
                        50
                    ).Value = studentName

                    insertCommand.Parameters.Add(
                        "@email",
                        MySqlDbType.VarChar,
                        100
                    ).Value = email

                    insertCommand.Parameters.Add(
                        "@password",
                        MySqlDbType.VarChar,
                        50
                    ).Value = password

                    insertCommand.ExecuteNonQuery()

                End Using

            End Using

            RaiseEvent RegisterRequested(
                studentID,
                studentName,
                email,
                password
            )

            lblStatus.ForeColor =
                Color.FromArgb(203, 161, 53)

            lblStatus.Text =
                "Student account created successfully."

            MessageBox.Show(
                "Student account created successfully.",
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            ClearRegistrationFields()

        Catch ex As MySqlException

            lblStatus.ForeColor = Color.Firebrick
            lblStatus.Text =
                "Database error: " & ex.Message

        Catch ex As Exception

            lblStatus.ForeColor = Color.Firebrick
            lblStatus.Text =
                "Error: " & ex.Message

        End Try

    End Sub
#End Region

#Region "Helper Methods"
    Private Sub ClearRegistrationFields()

        txtStuID.Clear()
        txtStuName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        chkShowPassword.Checked = False
        txtStuID.Focus()

    End Sub
#End Region

#Region "Navigation"
    Private Sub btnBack_Click(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles btnBack.Click

        Me.Close()

    End Sub
#End Region
End Class