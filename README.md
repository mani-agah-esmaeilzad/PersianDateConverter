# PersianDateConverter

## Description

This library is designed to convert new dates to Farsi and vice versa, as well as evaluate the validity of the input date to ensure that the input date is valid. This library will be very useful for developers who work with Iranian users. This package can provide functions that specify public holidays in Iran.

##Installation

To install this package, run the following command in the command line:
```
dotnet add package PersianDateConverter
```
## Use

To use this package, add the following code to your project:

```csharp
using PersianDateConverter;
```
Then you can use the functions in the ```Converter``` class.

## Example
```csharp
string persianDate = "1/1/1400";
DateTime gregorianDate = Converter.ToGregorian(persianDate);
Console.WriteLine(gregorianDate); // Outputs: 3/21/2021 12:00:00 AM

DateTime date = new DateTime(2021, 3, 21);
string PersianDate = Converter.ToPersian(date);
Console.WriteLine(persianDate); // Outputs: 1/1/1400
```
## participation
Any contribution to this project is welcome. To submit pull requests, please first create a branch and commit your changes to it.

NuGet Link: https://www.nuget.org/packages/PersianDateConverter/

## Contribution
If you wish to contribute to the development of this project, please fork and send pull requests. Additionally, you can report any bugs or suggestions through the Issues section.

## License
This project is released under the MIT license. For more information, please read the LICENSE file.

## Contact
If you have any questions or feedback, feel free to reach out:

Email: maniagahdev@gmail.com

Contact us: https://maniagah.ir/home/Contact

Instagram: @mani.aspx


We welcome your collaboration to improve this application!
