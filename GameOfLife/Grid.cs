using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife {
    public class Grid {

        public int generation;
        public bool[,] field;
        public int width;
        public int height;
        public List<bool[,]> oldGens = new List<bool[,]>();

        public Grid(int width, int height) {

            generation = 1;
            field = new bool[height, width];
            this.width = width;
            this.height = height;

            InitializeField();
        }

        public void InitializeField() {

            for(int i = 0; i < height; i++) {

                for(int j = 0; j < width; j++) {
                    field[i, j] = false;
                }
            }
        }

        public void SetField(int x, int y) {
            field[x, y] = true;
        }

        public void PrintField() {
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

        public void NextGeneration() {

            bool[,] nextGen = new bool[height,width];

            for(int i = 0; i < height; i++) {

                for(int j = 0; j < width; j++) {

                    nextGen[i,j] = IsAliveInNextGen(j, i);

                }
            }

            oldGens.Add(field);

            field = nextGen;
            generation++;

        }

        public bool IsAliveInNextGen(int x, int y) {

            int neighbours = Neighbours(x,y);

            bool isAlive = field[y, x];

            if(neighbours == 3) {
                return true;
            } else if (isAlive && neighbours == 2) {
                return true;
            }

            return false;
        }

        public int Neighbours(int x, int y) {

            int cellsNextToField = 0;

            //iterates through every field next to [x,y]
            for(int i = -1; i < 2; i++) {

                for(int j = -1; j < 2; j++) {

                    //Prevents counting the cell itself as a neighbour
                    if (!(i == 0 && j == 0)){
                        

                        Tuple<int,int> validPositions = CorrectIndex(x + j, y + i);

                        int xpos = validPositions.Item1;
                        int ypos = validPositions.Item2;

                        if (field[ypos, xpos]) {
                            cellsNextToField++;
                        }
                    }

                }
            }

            return cellsNextToField;
        }

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

            return new Tuple<int,int>(x,y);
        }
    }
}
