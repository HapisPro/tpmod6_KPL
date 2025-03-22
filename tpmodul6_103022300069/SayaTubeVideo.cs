using System;
using System.Diagnostics;

namespace tpmodul6_103022300069
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Prekondisi
            Debug.Assert(title != null, "Title tidak boleh kosong");
            Debug.Assert(title.Length > 0 && title.Length <= 100, "Batas panjang title adalah 1 - 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            // Prekondisi
            Debug.Assert(count > 0 && count <= 10000000, "Play count harus antara 1 - 10.000.000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError: Play count melebihi batas integer");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Judul: " + this.title);
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
