Вызываем метод Console.WriteLine() для вывода текста в консоль
Вызываем метод Console.WriteLine() для вывода текста в консоль
Создаем переменную input и присваиваем ей значение считываемое командой Console.Readline()
Создаем массив arr и присваиваем ему значие input с методом split который разбивает строки с разделителями на подстроки символом пробела
Создаем переменную result в которой будет храниться результат
Создаем переменную realSize и присваиваем ей значение 0
Используем оператор foreach (var value in arr) для итерации по элементам массива 
Оператор if (value.Length <= 3) выбирает оператор, который нужно выполнить, на основе значения логического выражения.
Используем присваивание result[realSize] = value для того что бы записывать в массив result все строки в которых менее 3 символов. 
realSize++ используем для того что бы переходить по элементам массива.
Вызываем метод Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize)) для вывода результата