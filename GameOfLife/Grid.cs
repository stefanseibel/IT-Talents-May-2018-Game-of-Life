using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife {
    public class Grid {
        
        //ATTRIBUTES:

        //counts the generations that have been simulated
        public int generation;
        

        //saves the field of the latest generation as a two-dimensional boolean-array
        //dead cells are saved as false and living cells as true
        public bool[,] field;

        //saves the height and width of the grid
        public int width;
        public int height;

        /*
         * saves all generations that have been created
         * mainly used to scroll in Form.trackBarGen
         */
        public List<bool[,]> allGens = new List<bool[,]>();


        //CONSTRUCTOR: initializes a new Grid with given width and height 
        public Grid(int width, int height) {

            // sets the current Generation to 1 (as there weren't any generations of this Grid before creating it
            generation = 1;
            
            //saves width and height as attributes from the given parameters)
            this.width = width;
            this.height = height;

            //creates a new field with the given width and height and initializes it with dead cells
            field = new bool[height, width];
            allGens.Add(field);
            InitializeField();
        }

        //METHODS:

        //initializes the field by setting every cell to false (dead)
        public void InitializeField() {

            //iterates through every cell of the latest field
            for(int i = 0; i < height; i++) {

                for(int j = 0; j < width; j++) {

                    //sets value of each cell to false (dead)
                    field[i, j] = false;
                }
            }
        }

        //prints the Field to the console (for testing only)
        public void PrintField(bool[,] field) {
            for (int i = 0; i < height; i++) {

                for (int j = 0; j < width; j++) {

                    if (field[i,j]) {
                        Console.Write("+ ");
                    } else {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // simulates a new generation based on the most recent field
        public void NextGeneration() {

            //creates a new field for the next generation
            bool[,] nextGen = new bool[height,width];

            //iterates through every cell of the latest field
            for (int i = 0; i < height; i++) {

                for(int j = 0; j < width; j++) {

                    // sets the cell in the next generation to its value according to the rules 
                    nextGen[i,j] = IsAliveInNextGen(j, i);

                }
            }

            //sets field to the new latest field
            field = nextGen;

            //adds the new field to allGens 
            allGens.Add(nextGen);

            //increments the count of generations
            generation++;

        }

        //checks if a cell at given coordinates will be alive in the next generation
        public bool IsAliveInNextGen(int x, int y) {

            //number of neighbours the cell has in the previous generation
            int neighbours = Neighbours(x,y);

            //says if the cell was alive in the previous generation
            bool isAlive = field[y, x];

            //sets the cell alive if it had three neighbours regardless of its state in the previous generation
            if(neighbours == 3) {
                return true;

            //sets the cell alive if it had two neighbours and was alive in the previous generation
            } else if (isAlive && neighbours == 2) {
                return true;
            }
            
            //sets the cell dead if none of the previous conditions were true
            return false;
        }

        //returns the number of neighbours of a cell at given coordinates
        public int Neighbours(int x, int y) {

            //saves the amount of neighbours while counting
            int cellsNextToField = 0;

            //iterates through every field next to [x,y]
            for(int i = -1; i < 2; i++) {

                for(int j = -1; j < 2; j++) {

                    //Prevents counting the cell itself as a neighbour
                    if (!(i == 0 && j == 0)){
                        
                        //changes the coordinates to being on the other side if nessecary in case of over-/underflow
                        Tuple<int,int> validPositions = CorrectIndex(x + j, y + i);

                        int xpos = validPositions.Item1;
                        int ypos = validPositions.Item2;

                        //increments the amount of neighbours if the neighbouring cell is alive (true)
                        if (field[ypos, xpos]) {
                            cellsNextToField++;
                        }
                    }

                }
            }

            //returns the amount of neighbours cell after iterating through and checking all of them
            return cellsNextToField;
        }
        
        //returns a tuple(Item1: correct X coordinate, Item2: correct Y coordinate) with coordinates that are inverted in case of over-/underflow
        public Tuple<int, int> CorrectIndex(int x, int y) {
            

            //checks for underflow and starts on the other side
            if (x == -1) {
                x = width - 1;

            //checks for overflow and starts on the other side
            } else if (x == width) {
                x = 0;
            }
            

            //checks for underflow and starts on the other side
            if (y == -1) {
                y = height - 1;

            //checks for overflow and starts on the other side
            } else if (y == height) {
                y = 0;
            }

            //returns a tuple with values that have been changed only in case of over-/underflow
            return new Tuple<int,int>(x,y);
        }

        public Tuple<int,int> FindPattern() {

            bool duplicateFound = false;

            int patternStart = 0;
            int patternEnd = 0;

            //Searches for Duplicates in existing list
            for (int i = 0; i < allGens.Count; i++) {
                //TODO: maybe change order of getRange for better Runtime 

                Predicate<bool[,]> p = (bool[,] b) => { return b.Cast<bool>().SequenceEqual(allGens[i].Cast<bool>()); };

                int duplicateIndex = allGens.GetRange(0,i).FindIndex(p);

                if (duplicateIndex >= 0) {

                    duplicateFound = true;

                    patternStart = duplicateIndex;
                    patternEnd = i;

                    //Breaks the for loop
                    i = allGens.Count;


                }

            }
            
            while (!duplicateFound) {

                NextGeneration();
                Predicate<bool[,]> p = (bool[,] b) => { return b.Cast<bool>().SequenceEqual(allGens.Last().Cast<bool>()); };

                int duplicateIndex = allGens.GetRange(0, allGens.Count - 1).FindIndex(p);
                

                if (duplicateIndex >= 0) {

                    duplicateFound = true;

                    patternStart = duplicateIndex;
                    patternEnd = allGens.Count - 1;

                }

            }

            Console.WriteLine(patternStart);
            Console.WriteLine(patternEnd);
            Console.WriteLine();

            return new Tuple<int, int>(patternStart, patternEnd);

        }
    }
}
