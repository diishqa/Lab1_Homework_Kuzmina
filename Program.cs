namespace Lab1_Homework_Kuzmina
{
    internal class Program
    {
        static void Main()
        {
            double chislai;
            double chislad;
            Console.WriteLine("Введите два числа: ");
            chislai= Convert.ToDouble(Console.ReadLine());
            chislad= Convert.ToDouble(Console.ReadLine());
            double summ = chislai + chislad;
            double razn = chislai - chislad;
            double proi = chislai * chislad;
            double chas = chislai / chislad;
            Console.WriteLine("Сумма: " + summ);
            Console.WriteLine("Разность: " + razn);
            Console.WriteLine("Произведение: " + proi);
            Console.WriteLine("Частное: " + chas);
            Console.ReadLine();
        }
    }
}
