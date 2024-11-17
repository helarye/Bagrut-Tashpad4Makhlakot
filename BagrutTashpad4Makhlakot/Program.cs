// See https://aka.ms/new-console-template for more information
using BagrutTashpad4Makhlakot;

Console.WriteLine("Hello, World!");
TourPackage myPac = new TourPackage(0,100,50,10);
Console.WriteLine(myPac);

//(1)תשפד שאלה 4 סעיף ב
static int Calculate(TourPackage[] packages)

//הפעולה מקבלת מערך חבילות תקשורת ומחזירה את כמות החריגות שהייתה בהם חריגה
{
    int kamutKhorgim = 0;
    for (int i = 0; i < packages.Length; i++)
    {
        if (packages[i].GetExtra() > 0) { kamutKhorgim++; }
    }
    return kamutKhorgim;
}
//(2)תשפד שאלה 4 סעיף ב
static int[] Customers(TourPackage[] packages)
{
    int kamutHorgim = Calculate(packages);
    int[] khorgimCust= new int[kamutHorgim];
    return khorgimCust;
}


