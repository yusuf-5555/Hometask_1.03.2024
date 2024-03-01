using Tasc2;


var photoBook = new PhotoBook (16);
System.Console.WriteLine(photoBook.GetNumberPages());


var photoBookTest = new PhotoBookTest (24);
System.Console.WriteLine(photoBookTest.GetNumberPages());


var bigphotoBook = new BigPhotoBook (64);
System.Console.WriteLine(bigphotoBook.GetNumberPages());
