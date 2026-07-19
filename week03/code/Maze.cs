/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
/// 
 /* 

    El método SetupMazeMap()
    private static Dictionary<ValueTuple<int, int>, bool[]> SetupMazeMap()
    {
        (2, 4) -> new[] { true, true, true, false }
    }
    devuelve un Dictionary completo. 
    
    Ese Dictionary se guarda en una VARIABLE llamada 'map'. 
    Dictionary<ValueTuple<int, int>, bool[]> map = SetupMazeMap(); 
    
    Después se crea un OBJETO con la clase Maze ( QUE ES LA CLASE QUE ESTAMOS CREANDO) 
    Que recibe como valos el diccionario que esta en el objeto map. 
    var maze = new Maze(map); 
    
    Dentro de esta clase existe otra subvlase con el mismo nombre: 
    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) 
    Que tiene el parametro 'mazeMap' 
    Ese parámetro recibe el valor de la variable 'map'
    Es decir todo el objeto. 
        (2, 4) -> new[] { true, true, true, false }
    Dentro del constructor ocurre:  
        _mazeMap = mazeMap; 
    Es decir que ahora  _mazeMap tiene estos valores: 
    (2, 4) -> new[] { true, true, true, false }
    
         resumiendo así que  _mazeMap contiene TODO el laberinto.

    Por ejemplo:

        (1,1) -> [false, true, false, true]
        (2,4) -> [true, true, true, false]
        (6,6) -> [true, false, false, false]

    Además, la clase Maze tiene otros dos ATRIBUTOS:

        _currX
        _currY

    Estos atributos guardan la posición actual del jugador.

    Por eso MoveLeft(), MoveRight(), MoveUp() y MoveDown()
    no necesitan recibir parámetros indicando la posición.
    La propia clase ya sabe dónde está el jugador.
*/
        
        
        // ahora sabiendo esto lo que tenemos que hacer es: 
        // 1. Obtener el bool[] de la posición actual (_currX, _currY).
        // 2. Consultar el índice correspondiente a "left".
        // 3. Si ese valor es false: throw InvalidOperationException.
        // 4. Si es true: _currX--;




public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    /// 
    /// 
    /// 
    public void MoveLeft()
    { 
        if (_mazeMap[(_currX, _currY)][0] == false){
            throw new InvalidOperationException("Can't go that way!");
        } else
        
            _currX--;
    
    }
    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap[(_currX, _currY)][1] == false){
            throw new InvalidOperationException("Can't go that way!");
        } else
        
            _currX ++;
     
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][2] == false){
            throw new InvalidOperationException("Can't go that way!");
        } else
        
            _currY--;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        if (_mazeMap[(_currX, _currY)][3] == false){
            throw new InvalidOperationException("Can't go that way!");
        } else
        
            _currY++;
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}