using System.Windows.Forms;

namespace Infrastructure.Methods
{
    public static class MessageBoxImplementation
    {
        /// <summary>
        /// Показывает пользователю сообщение об ошибке
        /// </summary>
        /// <param name="message">Сообщение ошибки</param>
        public static void ShowErrorMessage(string message = "Во время выполнения операции произошла ошибка.")
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Показывает пользователю сообщение - предупреждение
        /// </summary>
        /// <param name="message">Сообщение предупреждения</param>
        public static void ShowAllertMessage(string message)
        {
            MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Показывает пользователю сообщение - информацию
        /// </summary>
        /// <param name="message">Сообщение</param>
        public static void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Показывает пользователю сообщение - вопрос (Ответы Да/Нет)
        /// </summary>
        /// <param name="message"></param>
        /// <returns>При ответе да возвращает true</returns>
        public static bool AskMessageBox(string message)
        {
            return DialogResult.Yes == MessageBox.Show(message, "Подтвердите выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
