using System;

namespace Assignment01
{
    class Assignment01
    {
        static void Main(string[] args)
        {
            int menu;
            string repeat = "Y";

            Console.WriteLine("Assignment 01\n");
            Console.WriteLine("Kode peserta : FSDO002ONL003");
            Console.WriteLine("Nama : Alwi Azra Akbar Djunaid");
            Console.WriteLine("Alamat : Cinere, Depok\n");
            Console.WriteLine("Selamat datang di Assignment 01\n");

            do{
                do{
                    Console.WriteLine("\n\n=== Daftar Soal ===");
                    Console.WriteLine("1. Segitiga Huruf");
                    Console.WriteLine("2. Segitiga Angka");
                    Console.WriteLine("3. Faktorial");
                    Console.WriteLine("4. Reverse Number");
                    Console.WriteLine("5. Konversi angaka menjadi huruf dari angka tsb");
                    Console.WriteLine("6. Cek Palindrom dari Sebuah Kata");
                    Console.WriteLine("7. Tentang Saya");
                    Console.WriteLine("8. Exit");
                    Console.Write("Pilih menu : ");
                    menu = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                }while(menu < 1 || menu > 8);

                switch(menu){
                    case 1: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");
                        char ch='A';      
                        int i, j, k, m, input;

                        do{
                            Console.Write("Enter the range = ");
                            input = int.Parse(Console.ReadLine());
                        }while(input < 1 || input > 26);

                        for(i=1; i<=input; i++)      
                        {      
                            for(j=input; j>=i; j--)
                            {
                                Console.Write(" "); 
                            }     
                                
                            for(k=1;k<=i;k++) 
                            {
                                Console.Write(ch++);
                            }   

                            ch--;

                            for(m=1;m<i;m++)
                            {
                                Console.Write(--ch);
                            }   

                            Console.Write("\n");
                        }

                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 2: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");

                        int input;
                        int num='1';      
                        int i, j, k, m;

                        Console.Write("Enter the range = ");
                        input = int.Parse(Console.ReadLine());

                        for(i=1; i<=input; i++)      
                        {      
                            for(j=input; j>=i; j--)
                            {
                                Console.Write(" "); 
                            }     
                                
                            for(k=1 ;k<=i; k++) 
                            {
                                Console.Write(k);
                            }    

                            num--;

                            for(m=i - 1; m>=1; m--)
                            {
                                Console.Write(m);
                            }   
                            
                            Console.Write("\n");
                        }

                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 3: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");

                        int num;

                        Console.Write("Enter any number : ");
                        num = int.Parse(Console.ReadLine());

                        int result = num;

                        for(int i=result - 1; i>0; i--){
                            result *= i;
                        }

                        Console.WriteLine($"Factorial of {num} is : {result}");

                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 4: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");

                        string num;

                        Console.Write("Enter a number: ");
                        num = Console.ReadLine();

                        string str;
                        str = num.ToString();

                        char[] strArray = str.ToCharArray();
                        Array.Reverse(strArray);

                        Console.WriteLine($"Reversed Number : {new String(strArray)}");

                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 5: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");

                        string num;
                        string str = "";

                        Console.Write("Enter the Number : ");
                        num = Console.ReadLine();

                        for(int i=0; i<num.Length; i++){
                            if(num[i].Equals('1')){
                                str += "one ";
                            }
                            else if(num[i].Equals('2')){
                                str += "two ";
                            }
                            else if(num[i].Equals('3')){
                                str += "three ";
                            }
                            else if(num[i].Equals('4')){
                                str += "four ";
                            }
                            else if(num[i].Equals('5')){
                                str += "five ";
                            }
                            else if(num[i].Equals('6')){
                                str += "six ";
                            }
                            else if(num[i].Equals('7')){
                                str += "seven ";
                            }
                            else if(num[i].Equals('8')){
                                str += "eight ";
                            }
                            else if(num[i].Equals('9')){
                                str += "nine ";
                            }
                            else if(num[i].Equals('0')){
                                str += "zero ";
                            }
                        }

                        Console.WriteLine(str);

                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 6: {
                        Console.WriteLine($"Anda memilih soal nomor {menu}");
                        
                        string word;
                        bool isPalindrome = true;

                        Console.Write("Enter your word : ");
                        word = Console.ReadLine();

                        int left = 0;
                        int right = word.Length - 1;

                        for(int i=0; i<word.Length; i++){
                            if(word[left] == word[right]){
                                continue;
                            } else if(word[left] != word[right]){
                                isPalindrome = false;
                            }
                        }

                        if(isPalindrome){
                            Console.WriteLine("Your word is palindrome");
                        } else {
                            Console.WriteLine("Your word is not palindrome");
                        }
                        
                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 7:{
                        Console.WriteLine("Nama panggilan saya alwi, saya tinggal di depok dan kode peserta saya FSDO002ONL003");
                        Console.Write("\n\nKembali ke menu awal? (Y/N) : ");
                        repeat = Console.ReadLine();
                        break;
                    }
                    case 8:{
                        repeat = "N";
                        break;
                    }
                    default: {
                        break;
                    }
                }
            }while(repeat.Equals("Y") && menu != 8);
        }
    }
}
