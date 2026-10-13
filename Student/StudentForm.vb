'NG ZHENG KAI - A25DW0669 (SECTION J1)
Public Class StudentForm

    Private Sub StudentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If CurrentUserName <> String.Empty Then

            lblWelcome.Text =
                "Welcome, " & CurrentUserName
        Else
            lblWelcome.Text = "Welcome, Student"

        End If
        If CurrentUserID > 0 Then

            lblStudentID.Text =
                "Student ID: " &
                CurrentUserID.ToString()
        Else
            lblStudentID.Text = "Student ID: ---"

        End If
    End Sub


#Region "Button"
    Private Sub btnLogout_Click(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles btnLogout.Click

        Dim answer As DialogResult

        answer = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If answer = DialogResult.Yes Then

            ClearSession()
            Application.Exit()
        End If
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim BookForm As New BookForm
        BookForm.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim AboutForm As New AboutBox
        AboutForm.ShowDialog()

    End Sub
    Private Sub btnBorrowHistory_Click(sender As Object, e As EventArgs) Handles btnBorrowHistory.Click
        Dim BorrowHistory As New BorrowHistoryForm
        BorrowHistory.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim ReturnForm As New ReturnForm
        ReturnForm.ShowDialog()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim Borrow As New BorrowForm
        Borrow.ShowDialog()
    End Sub
#End Region


End Class