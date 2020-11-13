namespace Infrastructure.Enums
{
    public static class SQLEnums
    {
        public enum StoredProcedureNames
        {
            ДолжностиДобавить, ЗаявкиДобавить, СотрудникиДобавить, УслугиДобавить,
            ДолжностиИзменить, ЗаявкиИзменить, СотрудникиИзменить, УслугиИзменить
        }

        public enum QueryTypes { SELECT, SELECT_WHERE, DELETE }
    }
}
