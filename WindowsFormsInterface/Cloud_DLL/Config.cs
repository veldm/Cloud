using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_DLL
{
    public class Config
    {
        /// <summary>
        /// IP сервера
        /// </summary>
        public String IP_Adress;

        /// <summary>
        /// Порт, к которому выполняется подключение
        /// </summary>
        public int Port_Number;

        /// <summary>
        /// Указывает, надо ли проводить периодическую синхронизацию
        /// </summary>
        public Boolean Synchronize;

        /// <summary>
        /// Путь к папке
        /// </summary>
        public String LocalFolderPath;

        /// <summary>
        /// Период синхронизации в секундах
        /// </summary>
        public int SycnhronizeTime;
    }
}
