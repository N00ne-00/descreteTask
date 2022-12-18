using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number : "); // يسمح للمستخدم ان يدخل الرقمين لكي احدد المجال
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your number : ");
            int num2 = int.Parse(Console.ReadLine());


            for (int input = num1; input <= num2; input++) // اقوم بوضع المتغيرين في متغير واحد لكي اسطتيع ان اقوم بعمل loop عليه
            {
                if (input <= 1) // اقوم بعمل شرط اذا كان الرقم الذي يدخله المستخدم اقل من او يساوي ال 1 يكنسل المدخل دا لان مش عاوزة ال1 يكون رقم اولي
                {

                    continue;
                }
                else
                {
                    int x = 0; // اعرف متغير فرعي لكي اضعه في اللوب ويكون مسئول عن الزياده 
                    for (int i = 2; i < input; i++) // اعرف متغير الاعداد الاوليه بشكل طبيعي ولازم يكون اقل من المتغير في اللوب الكبيره
                    {
                        if (input % i == 0) // اضع الشرط الاساسي وهو اذا كان باقي القسمه ب 0 يزود الامتغير الفرعي الاول ويعمل بريك للرقم دا 
                        {
                            x = 1;
                            break;
                        } //هطلع برا اللوب  دي ومش هعمل else لانه لو عمل بريك هيكنسل اللوب كلها وانا عاوزه اتشيك كل الارقام علي المتغير الاصلي



                    }
                    if (x == 0) // اخر خطوة عملتها بره اللوب الصغيره لان لو ال x طلع ب 0 هيكون عدد اولي 
                    {
                        Console.WriteLine(input + " is a prime number"); // اطبع ان الرقم الذى دخل دا من وسط المجال اولي 
                    }
//thank you :)

                }
            }

        }
    }
}

