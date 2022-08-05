Console.WriteLine(Order("45 34 24 108 76 58 64 130 80")); // "130 24 34 80 108 45 64 58 76
Console.WriteLine(Order(" 2022 70 123 3344 13 ")); // "13 123 2022 70 3344"

string Order(string input)
{
    string spearator = " ";

    string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

    var sumlist = new List<int>();

    foreach (string str in strlist)
    {
        char[] ch = str.ToCharArray();

        int num = 0;

        for (int i = 0; i < ch.Length; i++)
        {
            num += int.Parse(ch[i].ToString());
        }

        sumlist.Add(num);
    }

    var sortedlist = sumlist.ToArray();

    int temp = 0;
    string temp2 = string.Empty;

    for (int write = 0; write < sortedlist.Length; write++)
    {
        for (int sort = 0; sort < sortedlist.Length - 1; sort++)
        {
            if (sortedlist[sort] > sortedlist[sort + 1])
            {
                temp = sortedlist[sort + 1];
                sortedlist[sort + 1] = sortedlist[sort];
                sortedlist[sort] = temp;

                temp2 = strlist[sort + 1];
                strlist[sort + 1] = strlist[sort];
                strlist[sort] = temp2;

                continue;
            }

            if (sortedlist[sort] == sortedlist[sort + 1])
            {
                string t1 = strlist[sort];
                var alphabetsort = new List<string> { strlist[sort], strlist[sort + 1] };
                alphabetsort.Sort();

                if (t1 == alphabetsort[1])
                {
                    temp = sortedlist[sort + 1];
                    sortedlist[sort + 1] = sortedlist[sort];
                    sortedlist[sort] = temp;

                    temp2 = strlist[sort + 1];
                    strlist[sort + 1] = strlist[sort];
                    strlist[sort] = temp2;
                }
            }
        }
    }

    return string.Join(" ", strlist);
}