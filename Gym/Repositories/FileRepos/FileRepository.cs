using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gym
{
    public abstract class FileRepository<T> : Repository<T> where T : IHuman
    {
        public string FileName { get; set; }
        protected bool Sync { get; set; } = true;

        public FileRepository(string filename)
            : base()
        {
            FileName = filename;
        }

        public abstract void ReadFromFile(); //зчитування з файлу (метод абстрактний, бо реалізація буде в дочірніх класах VisitorFileRepository
                                             //та TrainerFileRepository)
        public abstract void WriteToFile(); //запис у файл

        protected void SyncRead()
        {
            if (Sync)
            {
                data.Clear();
                ReadFromFile();
            }
        }
        private void SyncWrite()
        {
            if (Sync)
                WriteToFile();
        }


        public override void Add(T item)
        {
            base.Add(item);
            SyncWrite();
        }

        public override void Del(int indx)
        {
            base.Del(indx);
            SyncWrite();
        }

    }
}
