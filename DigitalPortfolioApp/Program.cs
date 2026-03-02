using System;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Создаем и показываем форму вручную
            LoginForm form = new LoginForm();
            form.ShowDialog(); // Показывает форму как диалог
        }
    }
}