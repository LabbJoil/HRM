
using System;
using System.Windows.Forms;
using Unity;

namespace TestTask.WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();

            using (var loading = new LoadingForm())
            {
                loading.Show(this);

                try
                {
                    await container.RegistrationDb(serverTextBox.Text, dataBaseTextBox.Text, loginTextBox.Text, passwordTextBox.Text);
                    container.RegistrationServices();
                    container.RegistrationRepositories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Не удалось подключиться к базе данных или настроить конфигурацию.\n{ex.Message}",
                        "Ошибка конфигурации",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;
                }
                finally
                {
                    loading.Close();
                }
            }

            var dataForm = container.Resolve<DataForm>();
            Hide();
            dataForm.ShowDialog();
            Close();
        }
    }
}
