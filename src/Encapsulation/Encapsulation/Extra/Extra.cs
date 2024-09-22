using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */


/*Buatlah sebuah kelas publik bernama WartegMenu yang digunakan untuk merepresentasikan sebuah menu makanan di warteg. Kelas WartegMenu memiliki tiga atribut privat yaitu:

_name (tipe String): nama makanan.
_price (tipe double): harga per porsi makanan.
_portion (tipe int): jumlah porsi yang tersedia.
Sediakan properti publik dengan metode set dan metode get untuk masing-masing atribut:

Properti Name: nama makanan tidak boleh berupa string kosong atau null, jika tidak, diatur menjadi "Unknown".
Properti Price: harga tidak boleh negatif, jika input negatif maka diatur menjadi 0.0.
Properti Portion: jumlah porsi tidak boleh negatif, jika input negatif maka diatur menjadi 0.
Tambahkan metode publik:

AddPortion(int portion): untuk menambah porsi makanan yang tersedia. Nilai portion tidak boleh negatif; jika negatif, tidak ada perubahan.
ReducePortion(int portion): untuk mengurangi porsi makanan yang tersedia. Pastikan jumlah porsi yang tersedia tidak menjadi negatif; jika kondisi tidak terpenuhi, porsi tidak berubah.
*/

/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

namespace Encapsulation.Extra
{
    public class WartegMenu
    {
        private string _name;
        private double _price;
        private int _portion;

        public WartegMenu(string name, double price, int portion)
        {
            Name = name;
            Price = price;
            Portion = portion;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0.0;
                }
            }
        }

        public int Portion
        {
            get { return _portion; }
            set
            {
                if (value >= 0)
                {
                    _portion = value;
                }
                else
                {
                    _portion = 0;
                }
            }
        }

        public void AddPortion(int portion)
        {
            if (portion > 0)
            {
                _portion += portion;
            }
        }

        public void ReducePortion(int portion)
        {
            if (portion > 0 && _portion - portion >= 0)
            {
                _portion -= portion;
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine($"Makanan: {Name}, Harga: {Price:C}, Porsi Tersedia: {Portion}");
        }
    }
}
