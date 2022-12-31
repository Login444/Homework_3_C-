void f(string x)
      {
          
          if ((x[0] == x[4]) && (x[1] == x[3]))
        {
            Console.WriteLine($"Число {x} - палиндром!");
        }
        else
        {
            Console.WriteLine($"Число {x} - не палиндром!");
        }
      }
        Console.WriteLine("Привет, сегодня мы попробуем проверить являются ли числа палиндромами.");
        string a = Convert.ToString(14212);
        string b = Convert.ToString(12821);
        string c = Convert.ToString(23432);
        Console.WriteLine($"Итак, наши числа {a},{b},{c} проверим что из них палиндром, а что нет.");
        f(a);
        f(b);
        f(c);