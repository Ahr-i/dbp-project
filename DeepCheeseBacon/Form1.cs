namespace deepcheesebacon
{
    public partial class form : Form
    {
        UserReg userReg = new UserReg();
        UserManage userManage = new UserManage();
        Salary salary = new Salary();
        SubjectManage subjectManage = new SubjectManage();
        AttendanceView attendanceView = new AttendanceView();
        AttendanceReg attendanceReg = new AttendanceReg();

        private Button? lastClickedItem;

        public form()
        {
            InitializeComponent();
        }



        private void MenuColor(object sender)
        {
            // ������ Ŭ���� �޴� ������ �� ������� ����
            if (lastClickedItem != null)
            {
                lastClickedItem.BackColor = Color.SteelBlue;
            }

            // ���� Ŭ���� �޴� ���� ����
            Button menu = (Button)sender;
            menu.BackColor = Color.SkyBlue;
            lastClickedItem = menu;
        }

        private void UserRegBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� ����� userReg ���
            pMain.Controls.Clear();
            pMain.Controls.Add(userReg);
        }

        private void UserManageBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� ����� userManage ���
            pMain.Controls.Clear();
            pMain.Controls.Add(userManage);
        }

        private void SubjectManageBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� ����� subjectManage ���
            pMain.Controls.Clear();
            pMain.Controls.Add(subjectManage);

        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� ����� salary ���
            pMain.Controls.Clear();
            pMain.Controls.Add(salary);
        }

        private void AttendRegBtn_Click(object sender, EventArgs e)
        {
            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� �����  attendanceReg ���
            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceView);
        }

        private void AttendancelogBtn_Click(object sender, EventArgs e)
        {

            MenuColor((Button)sender);

            // ���� �ǳڿ� �ִ� �ǳ� �����  attendanceReg ���
            pMain.Controls.Clear();
            pMain.Controls.Add(attendanceReg);
        }

    }
}
