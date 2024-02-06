using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static List<Student> students = new List<Student>();
    static List<Teacher> teachers = new List<Teacher>
    {
        //*******************Burda Sistem için hocalar belirlenmiştir*********************

        new Teacher("Atıl Emre COŞGUN", 1),
        new Teacher("Hasan DEMİR", 2),
        new Teacher("Emre AVUÇLU", 3),
        new Teacher("Bilal ŞENOL", 4)
    };

    static void Main()
    {

        //*********************************** BURDA ÖĞRENCİLER MANUEL OLARAK SİSTEME EKLENMİŞTİR********************************
        students.Add(new Student("Mehmet", "Doğan", 18));
        Console.WriteLine("Mehmet Doğan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Mehmet", "Yılmaz", 20));
        Console.WriteLine("Mehmet Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ayşe", "Kaya", 22));
        Console.WriteLine("Ayşe Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Fatma", "Güneş", 19));
        Console.WriteLine("Fatma Güneş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Emre", "Arslan", 21));
        Console.WriteLine("Emre Arslan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Zeynep", "Çetin", 23));
        Console.WriteLine("Zeynep Çetin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Burak", "Kurt", 20));
        Console.WriteLine("Burak Kurt öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Esra", "Erdem", 22));
        Console.WriteLine("Esra Erdem öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Gizem", "Öztürk", 19));
        Console.WriteLine("Gizem Öztürk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Okan", "Özkan", 21));
        Console.WriteLine("Okan Özkan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Selin", "Küşükarslan", 23));
        Console.WriteLine("Selin Küşükarslan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Can", "Acar", 20));
        Console.WriteLine("Can Acar öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Elif", "Turan", 22));
        Console.WriteLine("Elif Turan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Berk", "Kaya", 19));
        Console.WriteLine("Berk Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Melis", "Şahin", 21));
        Console.WriteLine("Melis Şahin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Efe", "Aydın", 23));
        Console.WriteLine("Efe Aydın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Sude", "Ergin", 20));
        Console.WriteLine("Sude Ergin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Yunus", "Demirtaş", 22));
        Console.WriteLine("Yunus Demirtaş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Selma", "Çelik", 19));
        Console.WriteLine("Selma Çelik öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kerem", "Yıldırım", 21));
        Console.WriteLine("Kerem Yıldırım öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Deniz", "Kara", 23));
        Console.WriteLine("Deniz Kara öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Eren", "Ateş", 20));
        Console.WriteLine("Eren Ateş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ceren", "Gündüz", 22));
        Console.WriteLine("Ceren Gündüz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Alp", "Türk", 19));
        Console.WriteLine("Alp Türk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Merve", "Uçar", 21));
        Console.WriteLine("Merve Uçar öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Baran", "Aygün", 23));
        Console.WriteLine("Baran Aygün öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Zehra", "Şen", 20));
        Console.WriteLine("Zehra Şen öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Hüseyin", "Kurtuluş", 22));
        Console.WriteLine("Hüseyin Kurtuluş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Cemre", "Gökgöl", 19));
        Console.WriteLine("Cemre Gökgöl öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kaan", "Demir", 21));
        Console.WriteLine("Kaan Demir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Zeynep", "Taş", 23));
        Console.WriteLine("Zeynep Taş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Tolga", "Kara", 20));
        Console.WriteLine("Tolga Kara öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Damla", "Yılmaz", 22));
        Console.WriteLine("Damla Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Caner", "Acar", 19));
        Console.WriteLine("Caner Acar öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Büşra", "Gürsoy", 21));
        Console.WriteLine("Büşra Gürsoy öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Umut", "Yılmaz", 23));
        Console.WriteLine("Umut Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ezgi", "Ergin", 20));
        Console.WriteLine("Ezgi Ergin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kerem", "Kaya", 22));
        Console.WriteLine("Kerem Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Selin", "Demir", 19));
        Console.WriteLine("Selin Demir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ali", "Koç", 21));
        Console.WriteLine("Ali Koç öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Aylin", "Güneş", 24));
        Console.WriteLine("Aylin Güneş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Görkem", "Taş", 22));
        Console.WriteLine("Görkem Taş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("İrem", "Şen", 20));
        Console.WriteLine("İrem Şen öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Burak", "Erdem", 23));
        Console.WriteLine("Burak Erdem öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Nazlı", "Ertürk", 21));
        Console.WriteLine("Nazlı Ertürk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kemal", "Turan", 19));
        Console.WriteLine("Kemal Turan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ece", "Acar", 22));
        Console.WriteLine("Ece Acar öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Can", "Yılmaz", 24));
        Console.WriteLine("Can Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Şeyma", "Kurtuluş", 20));
        Console.WriteLine("Şeyma Kurtuluş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Gökhan", "Kara", 23));
        Console.WriteLine("Gökhan Kara öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Deniz", "Çetin", 21));
        Console.WriteLine("Deniz Çetin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Zeynep", "Yıldırım", 24));
        Console.WriteLine("Zeynep Yıldırım öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Cihan", "Akgün", 22));
        Console.WriteLine("Cihan Akgün öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Naz", "Koç", 19));
        Console.WriteLine("Naz Koç öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Tolga", "Kaya", 23));
        Console.WriteLine("Tolga Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ece", "Demir", 20));
        Console.WriteLine("Ece Demir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Yasin", "Aydın", 22));
        Console.WriteLine("Yasin Aydın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Elif", "Yılmaz", 24));
        Console.WriteLine("Elif Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Emre", "Öztürk", 21));
        Console.WriteLine("Emre Öztürk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Elif", "Türkoğlu", 24));
        Console.WriteLine("Elif Türkoğlu öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Mert", "Göktürk", 22));
        Console.WriteLine("Mert Göktürk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Dilara", "Kaya", 19));
        Console.WriteLine("Dilara Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Yunus", "Demirbaş", 23));
        Console.WriteLine("Yunus Demirbaş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ayşe", "Özdemir", 21));
        Console.WriteLine("Ayşe Özdemir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Berk", "Karakaya", 19));
        Console.WriteLine("Berk Karakaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Eylül", "Güzel", 22));
        Console.WriteLine("Eylül Güzel öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ahmet", "Yıldız", 24));
        Console.WriteLine("Ahmet Yıldız öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Esra", "Kocaoğlu", 20));
        Console.WriteLine("Esra Kocaoğlu öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Cem", "Sönmez", 23));
        Console.WriteLine("Cem Sönmez öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Sena", "Aydın", 21));
        Console.WriteLine("Sena Aydın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Umut", "Erdem", 19));
        Console.WriteLine("Umut Erdem öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Yasin", "Taşkın", 22));
        Console.WriteLine("Yasin Taşkın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Derya", "Güney", 24));
        Console.WriteLine("Derya Güney öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kerim", "Yılmaz", 20));
        Console.WriteLine("Kerim Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Gizem", "Kara", 22));
        Console.WriteLine("Gizem Kara öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ömer", "Göktürk", 19));
        Console.WriteLine("Ömer Göktürk öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ezgi", "Erdemir", 23));
        Console.WriteLine("Ezgi Erdemir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Burak", "Güneş", 21));
        Console.WriteLine("Burak Güneş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Aslı", "Kurtuluş", 24));
        Console.WriteLine("Aslı Kurtuluş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Kaan", "Aydın", 22));
        Console.WriteLine("Kaan Aydın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Melis", "Demir", 19));
        Console.WriteLine("Melis Demir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ege", "Gürkan", 23));
        Console.WriteLine("Ege Gürkan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Gamze", "Taşkın", 21));
        Console.WriteLine("Gamze Taşkın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Caner", "Kaya", 19));
        Console.WriteLine("Caner Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ceren", "Demirtaş", 22));
        Console.WriteLine("Ceren Demirtaş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Hüseyin", "Akgün", 24));
        Console.WriteLine("Hüseyin Akgün öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Nisan", "Acar", 20));
        Console.WriteLine("Nisan Acar öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Berkay", "Koç", 23));
        Console.WriteLine("Berkay Koç öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Selma", "Yılmaz", 21));
        Console.WriteLine("Selma Yılmaz öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Furkan", "Turan", 19));
        Console.WriteLine("Furkan Turan öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Yasmin", "Kara", 22));
        Console.WriteLine("Yasmin Kara öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Serkan", "Yıldız", 24));
        Console.WriteLine("Serkan Yıldız öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ezgi", "Demirtaş", 20));
        Console.WriteLine("Ezgi Demirtaş öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Okan", "Kaya", 22));
        Console.WriteLine("Okan Kaya öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Selin", "Güzel", 19));
        Console.WriteLine("Selin Güzel öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Arda", "Şen", 23));
        Console.WriteLine("Arda Şen öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Ece", "Şahin", 21));
        Console.WriteLine("Ece Şahin öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Arif", "Kurt", 24));
        Console.WriteLine("Arif Kurt öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Zeynep", "Aydın", 22));
        Console.WriteLine("Zeynep Aydın öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        students.Add(new Student("Batuhan", "Demir", 19));
        Console.WriteLine("Batuhan Demir öğrencisi eklenmiştir. Okul numarası: " + students.Last().StudentNumber);

        AddManualStudentPreferences(); // burda ykarıda alınan öğrencilerin bilgileri manuel student  fonksiyonuna döndürülerek öğrenci ekleme işlemi gerçekleşir




        //****************************************************************************************************************************************************

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Öğrenci Listesini Görüntüle");
            Console.WriteLine("3. Tercih Listesi Oluştur");
            Console.WriteLine("4. Tercih Listesini Görüntüle");
            Console.WriteLine("5. Öğrencileri öğretmenlere dağıt");
            Console.WriteLine("6. Çıkış");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;                                                                      // Burda iki yıldızlı alan arasında kalan kısım bizim Menü kısmımızdır.
                case "2":                                                                      // Menü kısmında yapılan tercihler sonucunda her bir case bulunduğu işlemin olduğu  bir fonksiyona döndürme işlemi yürütür.                
                    DisplayAllStudents();
                    break;
                case "3":
                    CreatePreferenceList();
                    break;
                case "4":
                    DisplayPreferenceLists();
                    break;
                case "5":
                    DisturbateStudents();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
        //***************************************************************************************************************************************************

        /*
         1. Satır:
   - Program başladığında, bir liste öğrenci (students) ve öğretmen (teachers) tanımlanır.

3-10. Satırlar:
    - Sistem için öğretmenler manuel olarak belirlenir ve Teacher sınıfından nesneler oluşturulur.

12-19. Satırlar:
    - İki öğrenci manuel olarak sisteme eklenir ve eklenen öğrencinin okul numarası ekrana yazdırılır.

21. Satır:
    - AddManualStudentPreferences() fonksiyonu çağrılarak öğrencilere ait bilgiler manuel olarak girilir ve öğrenci ekleme işlemi gerçekleşir.

24-45. Satırlar:
    - Sonsuz bir döngü başlatılır ve kullanıcıya bir menü sunulur.
    - Kullanıcının seçimine göre ilgili fonksiyon çağrılır.

28. Satır:
    - "1. Öğrenci Ekle" seçeneği seçildiğinde çalışacak AddStudent() fonksiyonu çağrılır.

37. Satır:
    - "2. Öğrenci Listesini Görüntüle" seçeneği seçildiğinde çalışacak DisplayAllStudents() fonksiyonu çağrılır.

43. Satır:
    - "3. Tercih Listesi Oluştur" seçeneği seçildiğinde çalışacak CreatePreferenceList() fonksiyonu çağrılır.

49. Satır:
    - "4. Tercih Listesini Görüntüle" seçeneği seçildiğinde çalışacak DisplayPreferenceLists() fonksiyonu çağrılır.

55. Satır:
    - "5. Öğrencileri öğretmenlere dağıt" seçeneği seçildiğinde çalışacak DisturbateStudents() fonksiyonu çağrılır.

61. Satır:
    - "6. Çıkış" seçeneği seçildiğinde, program Environment.Exit(0) ile sonlandırılır.

67-70. Satırlar:
    - Kullanıcının geçerli bir seçim yapmadığı durumda "Geçersiz seçim. Lütfen tekrar deneyin." mesajı ekrana yazdırılır.


         
         - AddStudent(): Kullanıcıdan alınan bilgilerle yeni bir öğrenci oluşturup, bu öğrenciyi 'students' listesine ekler.

- DisplayAllStudents(): 'students' listesindeki tüm öğrencilerin bilgilerini ekrana yazdırır.

- CreatePreferenceList(): Her bir öğrenci için tercih listesi oluşturur. Öğrencilere, öğretmenler arasından tercih yapma imkanı tanır.

- DisplayPreferenceLists(): 'teachers' listesindeki her bir öğretmenin tercih listesini ekrana yazdırır.

- DisturbateStudents(): Öğrencileri tercih listelerine göre öğretmenlere dağıtarak eşleştirmeyi gerçekleştirir.

         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         */

        //********************************************** HER ÖĞRENCİYE AİT TERCİH LİSTELERİ ****************************************************************
        /*444. Satır:
   - 'AddManualStudentPreferences' adında bir fonksiyon tanımlanır. Bu fonksiyon, öğrencilere manuel olarak tercih listeleri ekler.
*/
        static void AddManualStudentPreferences()
        {
            // Öğrenci 1 tercih listesi
            students[0].AddPreferences(new List<int> { 4, 1, 2, 3 });
            students[1].AddPreferences(new List<int> { 4, 1, 2, 3 });

            // Öğrenci 2 tercih listesi
            students[2].AddPreferences(new List<int> { 2, 4, 1, 3 });
            // Öğrenci 3 tercih listesi
            students[3].AddPreferences(new List<int> { 1, 3, 4, 2 });

            // Öğrenci 4 tercih listesi
            students[4].AddPreferences(new List<int> { 3, 1, 2, 4 });


            // Öğrenci 5 tercih listesi
            students[5].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 6 tercih listesi
            students[6].AddPreferences(new List<int> { 1, 3, 2, 4 });

            // Öğrenci 7 tercih listesi
            students[7].AddPreferences(new List<int> { 2, 4, 1, 3 });

            // Öğrenci 8 tercih listesi
            students[8].AddPreferences(new List<int> { 1, 3, 2, 4 });

            // Öğrenci 9 tercih listesi
            students[9].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 10 tercih listesi
            students[10].AddPreferences(new List<int> { 3, 1, 2, 4 });

            // Öğrenci 11 tercih listesi
            students[11].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 12 tercih listesi
            students[12].AddPreferences(new List<int> { 1, 3, 2, 4 });

            // Öğrenci 13 tercih listesi
            students[13].AddPreferences(new List<int> { 3, 1, 4, 2 });

            // Öğrenci 14 tercih listesi
            students[14].AddPreferences(new List<int> { 2, 4, 3, 1 });

            // Öğrenci 15 tercih listesi
            students[15].AddPreferences(new List<int> { 1, 2, 3, 4 });

            // Öğrenci 16 tercih listesi
            students[16].AddPreferences(new List<int> { 4, 3, 1, 2 });

            // Öğrenci 17 tercih listesi
            students[17].AddPreferences(new List<int> { 2, 1, 4, 3 });

            // Öğrenci 18 tercih listesi
            students[18].AddPreferences(new List<int> { 3, 4, 2, 1 });

            // Öğrenci 19 tercih listesi
            students[19].AddPreferences(new List<int> { 1, 2, 4, 3 });

            // Öğrenci 20 tercih listesi
            students[20].AddPreferences(new List<int> { 3, 1, 4, 2 });

            // Öğrenci 21 tercih listesi
            students[21].AddPreferences(new List<int> { 2, 4, 3, 1 });

            // Öğrenci 22 tercih listesi
            students[22].AddPreferences(new List<int> { 1, 2, 3, 4 });

            // Öğrenci 23 tercih listesi
            students[23].AddPreferences(new List<int> { 4, 3, 1, 2 });

            // Öğrenci 24 tercih listesi
            students[24].AddPreferences(new List<int> { 2, 1, 4, 3 });

            // Öğrenci 25 tercih listesi
            students[25].AddPreferences(new List<int> { 3, 4, 2, 1 });

            // Öğrenci 26 tercih listesi
            students[26].AddPreferences(new List<int> { 1, 4, 2, 3 });

            // Öğrenci 27 tercih listesi
            students[27].AddPreferences(new List<int> { 3, 2, 1, 4 });

            // Öğrenci 28 tercih listesi
            students[28].AddPreferences(new List<int> { 4, 1, 3, 2 });

            // Öğrenci 29 tercih listesi
            students[29].AddPreferences(new List<int> { 2, 3, 4, 1 });

            // Öğrenci 30 tercih listesi
            students[30].AddPreferences(new List<int> { 1, 2, 4, 3 });

            // Öğrenci 31 tercih listesi
            students[31].AddPreferences(new List<int> { 4, 3, 2, 1 });

            // Öğrenci 32 tercih listesi
            students[32].AddPreferences(new List<int> { 3, 1, 4, 2 });

            // Öğrenci 33 tercih listesi
            students[33].AddPreferences(new List<int> { 2, 4, 1, 3 });

            // Öğrenci 34 tercih listesi
            students[34].AddPreferences(new List<int> { 1, 3, 2, 4 });

            // Öğrenci 35 tercih listesi
            students[35].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 36 tercih listesi
            students[36].AddPreferences(new List<int> { 3, 1, 2, 4 });

            // Öğrenci 37 tercih listesi
            students[37].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 38 tercih listesi
            students[38].AddPreferences(new List<int> { 1, 3, 2, 4 });

            // Öğrenci 39 tercih listesi
            students[39].AddPreferences(new List<int> { 3, 2, 4, 1 });

            // Öğrenci 40 tercih listesi
            students[40].AddPreferences(new List<int> { 2, 4, 1, 3 });

            // Öğrenci 41 tercih listesi
            students[41].AddPreferences(new List<int> { 4, 3, 1, 2 });

            // Öğrenci 42 tercih listesi
            students[42].AddPreferences(new List<int> { 2, 1, 4, 3 });

            // Öğrenci 43 tercih listesi
            students[43].AddPreferences(new List<int> { 3, 4, 1, 2 });

            // Öğrenci 44 tercih listesi
            students[44].AddPreferences(new List<int> { 1, 2, 3, 4 });

            // Öğrenci 45 tercih listesi
            students[45].AddPreferences(new List<int> { 4, 2, 1, 3 });

            // Öğrenci 46 tercih listesi
            students[46].AddPreferences(new List<int> { 3, 1, 4, 2 });

            // Öğrenci 47 tercih listesi
            students[47].AddPreferences(new List<int> { 2, 3, 4, 1 });

            // Öğrenci 48 tercih listesi
            students[48].AddPreferences(new List<int> { 1, 4, 2, 3 });

            // Öğrenci 49 tercih listesi
            students[49].AddPreferences(new List<int> { 4, 3, 1, 2 });

            // Öğrenci 50 tercih listesi
            students[50].AddPreferences(new List<int> { 2, 1, 4, 3 });

            students[51].AddPreferences(new List<int> { 1, 3, 4, 2 });
            students[52].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[53].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[54].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[55].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[56].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[57].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[58].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[59].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[60].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[61].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[62].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[63].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[64].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[65].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[66].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[67].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[68].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[69].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[70].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[71].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[72].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[73].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[74].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[75].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[76].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[77].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[78].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[79].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[80].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[81].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[82].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[83].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[84].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[85].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[86].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[87].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[88].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[89].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[90].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[91].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[92].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[93].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[94].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[95].AddPreferences(new List<int> { 4, 2, 1, 3 });
            students[96].AddPreferences(new List<int> { 1, 3, 2, 4 });
            students[97].AddPreferences(new List<int> { 2, 4, 1, 3 });
            students[98].AddPreferences(new List<int> { 3, 1, 2, 4 });
            students[99].AddPreferences(new List<int> { 4, 2, 1, 3 });



        }

    }

    /*
     /*
     
658-663. Satırlar:
   - 'AddStudent' adında bir fonksiyon tanımlanır. Kullanıcıdan öğrenci bilgilerini alarak yeni bir öğrenci oluşturur ve bu öğrenciyi 'students' listesine ekler.

671-683. Satırlar:
   - 'DisplayAllStudents' adında bir fonksiyon tanımlanır. 'students' listesindeki tüm öğrencilerin bilgilerini ekrana yazdırır.

691-762. Satırlar:
   - 'CreatePreferenceList' adında bir fonksiyon tanımlanır. Kullanıcıdan öğrenci numarası alarak ilgili öğrencinin tercih listesini oluşturur.

770-798. Satırlar:
   - 'DisplayPreferenceLists' adında bir fonksiyon tanımlanır. 'students' listesindeki her öğrencinin tercih listesini ekrana yazdırır.

806-828. Satırlar:
   - 'DisturbateStudents' adında bir fonksiyon tanımlanır. Öğrencileri tercih listelerine göre öğretmenlere dağıtarak eşleştirme işlemini gerçekleştirir.

836-871. Satırlar:
   - 'Main' fonksiyonu kapatılır.

879-896. Satırlar:
   - 'Student' sınıfı tanımlanır. Öğrenci nesnelerini temsil eder. Öğrenci sayısını takip eden bir sayacı barındırır.

898-914. Satırlar:
   - 'Teacher' sınıfı tanımlanır. Öğretmen nesnelerini temsil eder. Öğrencileri tutan bir liste içerir.

Her bir fonksiyonun işlevi:

- AddManualStudentPreferences():
  - İki öğrenci için manuel tercih listeleri ekler.

- AddStudent():
  - Kullanıcıdan alınan bilgilerle yeni bir öğrenci oluşturup, bu öğrenciyi 'students' listesine ekler.

- DisplayAllStudents():
  - 'students' listesindeki tüm öğrencilerin bilgilerini ekrana yazdırır.

- CreatePreferenceList():
  - Kullanıcının girdiği öğrenci numarasına sahip öğrencinin tercih listesini oluşturur ve kullanıcıya tercih yapma imkanı tanır.

- DisplayPreferenceLists():
  - 'students' listesindeki her bir öğrencinin tercih listesini ekrana yazdırır.

- DisturbateStudents():
  - Öğrencileri tercih listelerine göre öğretmenlere dağıtarak eşleştirmeyi 
     
*/







    static void AddStudent()
    {
        Console.Write("Öğrenci Adı: ");
        string name = Console.ReadLine();

        Console.Write("Öğrenci Soyadı: ");
        string surname = Console.ReadLine();

        Console.Write("Öğrenci Yaşı: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            Student student = new Student(name, surname, age);
            students.Add(student);

            Console.WriteLine($"{student.FullName} öğrencisi eklenmiştir. Okul numarası: {student.StudentNumber}");
        }
        else
        {
            Console.WriteLine("Geçersiz yaş değeri. Lütfen bir sayı girin.");
        }
    }

    static void DisplayAllStudents()
    {
        Console.WriteLine("Okulda bulunan toplam öğrenci listesi:");

        foreach (var student in students)
        {
            Console.WriteLine($"Ad Soyad: {student.FullName}, Yaş: {student.Age}, Okul Numarası: {student.StudentNumber}");
        }
    }

    static void CreatePreferenceList()
    {
        Console.Write("Öğrenci Okul Numarası: ");
        if (int.TryParse(Console.ReadLine(), out int studentNumber))
        {
            Student student = students.FirstOrDefault(s => s.StudentNumber == studentNumber);

            if (student != null)
            {
                Console.WriteLine("Öğrencinin tercih listesi için aşağıdaki öğretmenlerden birini seçiniz:");
                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"{teacher.TeacherNumber}-{teacher.TeacherName}");
                }

                Console.Write("Tercih Listesi (örnek: 4,2,1,3): ");
                string[] preferenceArray = Console.ReadLine().Split(',');

                List<int> preferences = new List<int>();
                foreach (var item in preferenceArray)
                {
                    if (int.TryParse(item, out int preference))
                    {
                        preferences.Add(preference);
                    }
                }

                student.AddPreferences(preferences);
                Console.WriteLine($"{student.FullName} öğrencisinin tercih listesi oluşturulmuştur.");

                Console.Write("Yeni bir tercih eklemek ister misiniz? (Evet/Hayır): ");
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "evet")
                {
                    CreatePreferenceList();
                }
            }
            else
            {
                Console.WriteLine("Belirtilen okul numarasına sahip öğrenci bulunamadı. Lütfen geçerli bir okul numarası girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz okul numarası. Lütfen bir sayı girin.");
        }
    }
    static void DisplayPreferenceLists()
    {
        Console.WriteLine("Öğrenci Tercih Listeleri:");

        foreach (var student in students)
        {
            Console.WriteLine($"Öğrenci No: {student.StudentNumber}, Ad Soyad: {student.FullName}");

            Console.WriteLine("  Tercih Listesi:");
            for (int i = 0; i < student.Preferences.Count; i++)
            {
                int teacherNumber = student.Preferences[i];
                Teacher selectedTeacher = teachers.FirstOrDefault(t => t.TeacherNumber == teacherNumber);

                if (selectedTeacher != null)
                {
                    Console.WriteLine($"    {i + 1}. Tercih: {selectedTeacher.TeacherName}");
                }
                else
                {
                    Console.WriteLine($"    {i + 1}. Tercih: Bilinmeyen Öğretmen");
                }
            }

            Console.WriteLine();
        }
    }

    static void DisturbateStudents()
    {
        Random rng = new Random();
        var shuffledStudents = students.OrderBy(a => rng.Next()).ToList();
        foreach (var student in shuffledStudents)
        {
            foreach (var preference in student.Preferences)
            {
                var teacher = teachers[preference - 1];
                if (teacher.students.Count < 25)
                {
                    teacher.students.Add(student);
                    break;
                }
            }
        }

        foreach (var teacher in teachers)
        {
            Console.WriteLine($"\n\n[{teacher.TeacherName}]");
            foreach (var student in teacher.students)
            {
                Console.WriteLine(student.FullName);
            }
        }
    }
}

class Student
{
    private static int studentCount = 0;

    public string Name { get; }
    public string Surname { get; }
    public string FullName => $"{Name} {Surname}";
    public int Age { get; }
    public int StudentNumber { get; }
    public List<int> Preferences { get; private set; }

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        StudentNumber = ++studentCount;
        Preferences = new List<int>();
    }

    public void AddPreferences(List<int> preferences)
    {
        Preferences = preferences;
    }
}

class Teacher
{
    public string TeacherName { get; }
    public int TeacherNumber { get; }
    public List<Student> students = new();

    public Teacher(string name, int number)
    {
        TeacherName = name;
        TeacherNumber = number;
    }
}

