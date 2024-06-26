# PersianDateConverter

## Description

This library is designed to convert new dates to Farsi and vice versa, as well as evaluate the validity of the input date to ensure that the input date is valid. This library will be very useful for developers who work with Iranian users. This package can provide functions that specify public holidays in Iran.

## Version

This is version 1.2.0 of the PersianDateConverter

## Installation

To install this package, run the following command in the command line:
```
dotnet add package PersianDateConverter
```
## Use

To use this package, add the following code to your project:

```csharp
using PersianDateConverter;
```
Then you can use the functions in the ```Converter``` class

## Example
```csharp
string persianDate = "1/1/1400";
DateTime gregorianDate = Converter.ToGregorian(persianDate);
Console.WriteLine(gregorianDate); // Outputs: 3/21/2021 12:00:00 AM

DateTime date = new DateTime(2021, 3, 21);
string PersianDate = Converter.ToPersian(date);
Console.WriteLine(persianDate); // Outputs: 1/1/1400

string persianDateShort = Converter.ToPersianShort(date);
Console.WriteLine(persianDateShort); // Outputs: 1402/12/20

string persianDateLong = Converter.ToPersianLong(date);
Console.WriteLine(persianDateLong); // Outputs: 1402/12/20 12:00:00 AM

string persianDateWithWords = Converter.ToPersianDateWithWords("1402/12/01");
Console.WriteLine(persianDateWithWords); // Outputs: یکم فروردین هزار و چهارصد و یک

string gregorianDateWithWords = Converter.ToGregorianWithWords(new DateTime(2024, 1, 1));
Console.WriteLine(gregorianDateWithWords); // Outputs: 1 January 2024
```
## Participation
Any contribution to this project is welcome. To submit pull requests, please first create a branch and commit your changes to it.

NuGet Link: https://www.nuget.org/packages/PersianDateConverter/

## Contribution
If you wish to contribute to the development of this project, please fork and send pull requests. Additionally, you can report any bugs or suggestions through the Issues section.

## License
This project is released under the MIT license. For more information, please read the [LICENSE](https://choosealicense.com/licenses/mit/) file.

## Contact
If you have any questions or feedback, feel free to reach out:

Email: maniagahdev@gmail.com

Contact us: https://maniagah.ir/home/Contact

Instagram: www.instagram/mani.aspx

We welcome your collaboration to improve this application!
