# Задание 1. Реализовать один интерфейс с одним методом в производном классе.

1.Создайте интерфейс с именем IInterface.

2.Создайте в интерфейсе метод Method().

3.Создайте производный класс DerivedClass, который реализует интерфейс IInterface.

4.Реализуйте метод Method() в классе DerivedClass, чтобы в консольном окне выводился текст:

Метод, реализованный в классе DerivedClass

5.В методе Main() создайте объект dClass и вызовите метод Method().

# Задание 2. Объявить один интерфейс, в котором содержатся 4 метода:

1.метод, возвращающий число PI;

2.метод, возвращающий число типа int;

3.метод, возвращающий x в квадрате;

4.метод, возвращающий корень квадратный из x.

Реализовать интерфейс в классе MyClass, использующем этот интерфейс. Класс обязательно должен реализовать все методы интерфейса.

# Задание 3. Создание нескольких интерфейсов, множественное наследование интерфейсов и их реализация.

1.Создайте интерфейсы IInterface1, IInterface2, IInterface3.

2.Интерфейс IInterface2 наследуйте от интерфейса IInterface1.

3.Интерфейс IInterface3 наследуйте от интерфейса IInterface2.

4.В каждом интерфейсе создайте по одному методу с соответствующими именами: Method1(), Method2(), Method3().

5.Создайте производный класс DerivedClass, который наследуется от интерфейса IInterface3.

6.В классе DerivedClass реализуйте все три метода Method1(), Method2(), Method3().

7.В методе Main() создайте объект dClass и вызовите все методы, чтобы в консольном окне был выведен следующий текст:

Метод Method1

Метод Method2

Метод Method3

# Задание 4. Реализация в классе Человек двух не связанных между собой интерфейсов размышления и разговора.
![image](https://github.com/user-attachments/assets/6bc7a004-cf92-4f4f-87f1-25b6d8f75bf3)





# Задание 5. Создание интерфейса, в котором объявлены два метода. Создание двух классов, которые будут реализовывать один и тот же интерфейс.

1.Создайте интерфейс ISwitchable, в котором объявите два метода – включение и выключение.

2.Реализуйте интерфейс в классе TVSet с методами включения и выключения телевизора.

3.Реализуйте интерфейс в классе PersonalComputer с методами включения и выключения компьютера.

4.С использованием списка вызовите методы созданных классов.

# Задание 6. Создание двух интерфейсов, описывающих методы четырех основных арифметических операций и операций возведения в квадрат, извлечения квадратного корня. Описание класса А, реализующего интерфейс основных арифметических операций. Кроме этого создание класса Аа, унаследованного от класса А, но при этом не нужно заново реализовывать интерфейс, нужно только переопределить некоторые его методы.  И создание класса Ab, унаследованного от класса А и при этом реализуется интерфейс с методами возведения в квадрат, извлечения квадратного корня.
![image](https://github.com/user-attachments/assets/be0cb4cb-2efd-4857-9003-a2187d293ce6)



# Задание 7. Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. Написать программу, которая выполняет проигрывание и запись.

