using System;

namespace Infrastructure.Enums
{
    public static class SQLEnums
    {
        public static string GetTableName(TableNames selected) => Enum.GetName(typeof(TableNames), selected).Replace("_", " ");
        public enum TableNames
        {
            Архив_клиентов, Должности, Дополнительная_информация_клиентов, Заявки, Клиенты, Роли, Сотрудники, Типы_заявок, Услуги
        }

        public enum StoredProcedureNames
        {
            ДолжностиДобавить, ЗаявкиДобавить, СотрудникиДобавить, ТипыЗаявокДобавить,
            УслугиДобавить, ДопинфоДобавить, КлиентыДобавить,
            ДолжностиИзменить, ЗаявкиИзменить, СотрудникиИзменить, ТипыЗаявокИзменить,
            УслугиИзменить, ДопинфоИзменить, КлиентыИзменить,
            ЛидДобавить, ПереносКлиентаВАрхив, УдалитьПустыеДопИнфо, ОбнулитьПустыеДопИнфоКлиентов, СписокРазрешенийДляРоли
        }

        public enum QueryTypes { SELECT, SELECT_WHERE, DELETE }
    }
}
