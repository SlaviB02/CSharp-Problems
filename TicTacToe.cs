char[,] board = new char[3,3];
fillBoard(board);
char[,] positions=new char[3,3];
fillPositions(positions);
printBoardPlaces(board,positions);
Console.WriteLine("Insert name player 1: ");
var p1 = Console.ReadLine();
Console.WriteLine("Insert name player 2: ");
var p2=Console.ReadLine();
Console.Clear();
var index = 0;
char winner='a';
while (true)
{
    
    if(checkWin(board)==true)
    {
        printBoard(board);
        Console.WriteLine("Game OVER!");
        if(winner=='O')
        {
            Console.WriteLine($"{p1} wins!");
        }
        else
        {
            Console.WriteLine($"{p2} wins!");
        }
        break;
        
    }
    if (isFull(board) == true)
    {
        printBoardPlaces(board, positions);
        Console.WriteLine("Board is full! Game OVER!");
        break;
    }
    printBoardPlaces(board, positions);

    if (index%2==0)
    {
        Console.WriteLine($"{p1}'s turn");
        Console.WriteLine("Choose where to place O");
        var pos = int.Parse(Console.ReadLine());
        var el = 'O';
        updateBoard(pos, el);
        
    }
    if(index%2==1)
    {
        Console.WriteLine($"{p2}'s turn");
        Console.WriteLine("Choose where to place X");
        var pos = int.Parse(Console.ReadLine());
        var el = 'X';
        updateBoard(pos, el);
    }
    index++;
    Console.Clear();
    if(isFull(board)==true)
    {

    }
}
void updateBoard(int pos,char element)
{
    var firstIndex = 0;
    var secondIndex = 0;
    var flag = true;
    
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {

            if (positions[i,j] == Convert.ToChar(pos + 48))
            {
                firstIndex = i;
                secondIndex = j;
                positions[i,j] = '*';
                flag = false;
            }
            
        }
    }

    winner = element;
    if (flag==true)
    {
        Console.WriteLine("This position is already taken!");
        Console.WriteLine("Choose where to place " + element);
        var position = int.Parse(Console.ReadLine());
        updateBoard(position, element);
    }
    else
    {
        board[firstIndex, secondIndex] = element;
    }
    
}
bool checkWin(char[,]board)
{
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i,1] && board[i, 1] == board[i,2] && board[i,1]!='-')
        {
            return true; 
        }
        if (board[0, i] == board[1,i] && board[1,i] == board[2,i] && board[0,i]!='-')
        {
            return true;
        }
       
    }
    if (board[0, 0] == board[1,1]&& board[1,1]== board[2,2]&& board[0, 0] != '-')
    {
        return true;
    }
    if (board[2, 0] == board[1,1]&& board[0, 2] == board[1,1] && board[1, 1] != '-')
    {
        return true;
    }
    return false;
}
void fillPositions(char[,] board)
{
    var count = 49;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            positions[i, j] = Convert.ToChar(count);
            count++;
        }
    }
}
void fillBoard(char[,] board)
{
    
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
        {
            board[i, j] = '-';
        }
}

void printBoardPlaces(char[,] board, char[,]places)
{
    Console.WriteLine("       Board                  Positions");
    for (int i = 0;i < 3; i++)
    {
       
        Console.WriteLine(" *******************     *******************");
        for (int j = 0;j < 3; j++)
        {
          
           Console.Write(" | "+board[i, j] + " | ");

        }
        Console.Write("   ");
        for(int j = 0;j<3;j++)
        {
            Console.Write(" | " + places[i, j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" *******************     *******************");
}
void printBoard(char[,]board)
{
    Console.WriteLine("       Board");
    for (int i = 0; i < 3; i++)
    {

        Console.WriteLine(" *******************");
        for (int j = 0; j < 3; j++)
        {

            Console.Write(" | " + board[i, j] + " | ");

        }
        Console.WriteLine();
    }
    Console.WriteLine(" *******************");
}
bool isFull(char[,] board)
{
    bool flag = true;
    for(int i = 0;i<3;i++)
    {
        for(int j = 0;j<3; j++)
        {
            if (board[i,j] == '-') {
                flag = false;
            }
        }
    }
    if(flag==true)
    {
        return true;
    }
    return false;
}