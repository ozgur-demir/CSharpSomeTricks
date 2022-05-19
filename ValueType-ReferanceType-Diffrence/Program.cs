
int number = 5;
Console.WriteLine("Default Number:"+number);
EditAsValueType(number);
Console.WriteLine("After Edit(ValueType):" + number);
EditAsReferanceType(ref number);
Console.WriteLine("After Edit(ReferanceType):" + number);



static void EditAsValueType(int number)
{
    number = number + 5;
}
static void EditAsReferanceType(ref int number)
{
    number = number + 5;
}