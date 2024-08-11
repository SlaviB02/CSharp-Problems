int HardestWorker(int n, int[][] logs)
{
    int currentTime = 0;
    int maxLength = 0;
    int maxId = 0;

    currentTime = logs[0][1];
    int tempId = logs[0][0];

    if (currentTime > maxLength)
    {
        maxLength = currentTime;
        maxId = tempId;
    }

    for (int i=1;i<logs.Length;i++)
    {

       
        int empId=logs[i][0];
        int taskTime=logs[i][1];

        currentTime = taskTime - logs[i - 1][1];

        if(currentTime > maxLength)
        {
            maxLength = currentTime;
            maxId=empId;
        }

       else if(currentTime==maxLength)
        {
            if(maxId>empId)
            {
                maxId = empId;
            }
            
        }
       
    }

    return maxId;
}

int n = 70;
int[][] logs = [[36, 3], [1, 5], [12, 8], [25, 9], [53, 11], [29, 12], [52, 14]];

int res=HardestWorker(n, logs);

Console.WriteLine(res);