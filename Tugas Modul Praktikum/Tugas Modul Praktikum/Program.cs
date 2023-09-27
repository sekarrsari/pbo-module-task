using PROCESSOR;
using VGA;
using LAPTOP;

namespace PROCESSOR
{
    class Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
}


namespace VGA
{
    class Vga
    {
        public string merk;
    }

    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}


namespace LAPTOP
{
    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga { get; set; }
        public Processor processor { get; set; }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ============== INSTRUKSI NO. 4 ==============
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();

        // ============== INSTRUKSI NO. 5 ==============
        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new VGA.AMD();
        laptop2.processor = new Ryzen();

        // ============== INSTRUKSI NO. 6 ==============
        Predator predator = new Predator();
        predator.vga = new VGA.AMD();
        predator.processor = new CoreI7();

        Console.WriteLine("--------------- SOAL NO. 1 ---------------");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("\n--------------- SOAL NO. 2 ---------------");
        //laptop1.Ngoding(); ERROR

        Console.WriteLine("\n----------------------------- SOAL NO. 3 -----------------------------");
        Console.WriteLine($"laptop1 adalah laptop {laptop1.merk} {laptop1.tipe} dengan spesifikasi sebagai berikut");
        Console.WriteLine("Merk VGA       : " + laptop1.vga.merk);
        Console.WriteLine("Merk Processor : " + laptop1.processor.merk);
        Console.WriteLine("Tipe Processor : " + laptop1.processor.tipe);

        Console.WriteLine("\n--------------- SOAL NO. 4 ---------------");
        predator.BermainGame();

        Console.WriteLine("\n--------------- SOAL NO. 5 ---------------");
        ACER acer = new Predator();
        //acer.BermainGame(); ERROR
    }
}