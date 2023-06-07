string getTime(DateTime createdTime)
{
    DateTime now = DateTime.Now;
    //TimeSpan ts = DateTime.Now - createTime;
    TimeSpan ts = now.Subtract(createdTime);
    if (DateTime.Compare(now, createdTime) == -1)
    {
        return "Not correct date";
    }
    else
    {

        if (ts.Days >= 365)
        {
            return ts.Days / 365 + (ts.Days / 365 == 1 ? " year" : " years");
        }
        else if (ts.Days >= 30) { 
            return ts.Days / 30 + (ts.Days / 30 == 1 ? " month" : " months");}
        else if (ts.Days >= 7) { 
            return ts.Days / 7 + (ts.Days / 7 == 1 ? " week" : " weeks");}
        else if (ts.Days > 0) { 
            return ts.Days + (ts.Days == 1 ? " day" : " days");}
        else if (ts.Minutes > 0) { 
            return ts.Minutes + (ts.Minutes == 1 ? " minute" : " minutes");}
        else { 
            return ts.Seconds + (ts.Seconds == 1 ? " secomd" : " seconds");}
    }
}


Console.WriteLine(getTime(new DateTime(2023, 6, 7, 12, 13, 10)));