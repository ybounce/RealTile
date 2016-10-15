using System;

namespace COIS4050Q3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("TILE PROBLEM!");


			int k = 2;
			int length = Convert.ToInt32(Math.Pow(2, k));
			int[,] grid = new int[length, length];
			// Fill the Grid 
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < Math.Pow(2, k); j++)
				{
					grid[i, j] = 0;


				}
			}
			int[,] fake = new int[4, 4] {{4,4,5,5},
											{4,1,2,5},{6,2,2,3},
				{6,6,3,3}};

			int[,] fake2 = new int[8, 8] {{10,10,11,11,15,15,16,16},
{10,8,8,11,15,13,13,16},
{12,8,9,9,17,17,13,14},
{12,12,9,2,2,17,14,14},
{20,20,21,2,1,5,6,6},
{20,18,21,21,5,5,3,6},
{22,18,18,19,7,3,3,4},
				{22,22,19,19,7,7,4,4}};
			print(8, fake2);

			int x = 3, y = 3;
			grid[x, y] = 1;
			//print(length, grid);
			//findZone(x, y, 0, 0, 3, 3, 2, grid);
			//print(length, grid);


		}
		// Printing Class 
		static void print(int size, int[,] grid)
		{
			Console.WriteLine();
			int length = size;
			for (int j = 0; j < length; j++)
			{
				for (int i = 0; i < length; i++)
				{
					Console.Write(grid[i, j] + ",");

				}
				Console.WriteLine();

			}
			Console.WriteLine();
		}
		// Finding where the square tile is 

		/*static void fillTheBlanks(int length, int x, int y,int counter,int count, int[,] grid)
		{

			while (length > 7)
			{
				
				switch (findZone(x, y, length, grid))
				{
					case 0:
						grid[(length*counter/2)-1, (length*counter / 2) - 1] = count;
						grid[(length * counter / 2), (length * counter / 2) - 1] = count;
						grid[(length * counter / 2) - 1, (length * counter / 2)] = count;
						Console.WriteLine("Sout East");

						counter++;
						break;
					case 1:
						Console.WriteLine("North East");
						grid[(length * counter / 2) - 1, (length * counter / 2) - 1] = count;
						grid[(length * counter / 2), (length * counter / 2)] = count;
						grid[(length * counter / 2) - 1, (length * counter / 2)] = count;
						counter++;
						break;
					case 2:
						Console.WriteLine("South West");
						grid[(length * counter / 2) - 1, (length * counter / 2) - 1] = count;
						grid[(length * counter / 2), (length * counter / 2)] = count;
						grid[(length / 2), (length / 2)-1] = count;
						counter++;
						break;
					case 3:
						Console.WriteLine("North West");
						grid[(length * counter / 2), (length * counter / 2) - 1] = count;
						grid[(length * counter / 2), (length * counter / 2)] = count;
						grid[(length * counter / 2) - 1, (length * counter / 2)] = count;
						counter++;
						break;

					default:
						Console.WriteLine("Default case");
						break;
				}

				length=length/2; 

			}


		}*/
		static void findZone(int i, int j, int xStart, int yStart, int xEnd, int yEnd, int count, int[,] grid)
		{
			//if (xEnd - xStart > 0 && yEnd-yStart>0)
			//{

			if ((i - xStart+1) > ((xEnd-xStart+1) / 2))
				{
					if (j - yStart+1 > ((yEnd - yStart+1) / 2))
				{
					int v,z;
					//soutEast
					//Filling up the L Shapes
					Console.WriteLine("SouthEast");
					v = ((xEnd - xStart + 1) / 2) - 1;
					z = ((yEnd - yStart + 1) / 2) - 1;
					Console.WriteLine(v+","+z);
					grid[((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1 )/ 2) - 1] = count;//top left 



					v=((xEnd - xStart + 1) / 2);
					z = ((yEnd - yStart + 1) / 2) - 1;
					Console.WriteLine(v + "," + z);


						grid[((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2) - 1] = count;//
					v = ((xEnd - xStart + 1) / 2)-1;
					z = ((yEnd - yStart + 1) / 2) ;

					Console.WriteLine(v + "," + z);
						grid[((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1) / 2)] = count;
					Console.WriteLine("Sout East");
						count++;
					print(4, grid);
					Console.ReadLine(); 
						if (xEnd - xStart >2)
						{
							//South East
							findZone(i, j, ((xEnd + 1) / 2) , ((yEnd + 1) / 2) , xEnd, yEnd, count, grid);
							// North west side 
							findZone(((xEnd - xStart + 1) / 2) - 1, ((yEnd - yStart + 1) / 2) - 1, xStart, yStart, ((xEnd + 1) / 2) - 1, ((yEnd + 1) / 2) - 1, count, grid);
							//North east side 
							findZone(((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
							//South West
							findZone(((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1) / 2), xStart, ((yEnd + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yEnd, count, grid);
						}



						else
						{

							//North East
							//Filling up the L Shapes 
							grid[((xEnd - xStart + 1) / 2) - 1, ((yEnd - yStart + 1) / 2) - 1] = count;
							grid[((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2)] = count;
							grid[((xEnd - xStart + 1) / 2) - 1, ((yEnd - yStart + 1) / 2)] = count;
							Console.WriteLine("North East");
							count++;
							if (xEnd - xStart >0)
							{
								//North East
								findZone(i, j, ((xEnd + 1) / 2), yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
								// North west side 
								findZone(((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1) / 2) - 1, xStart, yStart, ((xEnd + 1) / 2) - 1, ((yEnd + 1) / 2) - 1, count, grid);
								//South East side 
								findZone(((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
								//South West
								findZone(((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1) / 2), xStart, ((yEnd + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yEnd, count, grid);
							}

						}
					}
					else
					{
						if (j - yStart+1 >= ((yEnd - yStart+1) / 2))
						{
							//South west
							//Filling up the L Shapes 
							grid[((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1) / 2) - 1] = count;//3,3 north west
							grid[((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2)] = count;//4,4 south east 
							grid[((xEnd - xStart + 1 )/ 2), ((yEnd - yStart + 1) / 2) - 1] = count;//4,3 north east 
							Console.WriteLine("South West");
							count++;
							if (xEnd - xStart > 0)
							{
								//South West 
								findZone(i, j, xStart, ((yEnd + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yEnd, count, grid);
								// North west side 
								findZone(((xEnd - xStart + 1 )/ 2) - 1, ((yEnd - yStart + 1 )/ 2) - 1, xStart, yStart, ((xEnd + 1) / 2) - 1, ((yEnd + 1) / 2) - 1, count, grid);
								//South East side 
								findZone(((xEnd - xStart + 1 )/ 2), ((yEnd - yStart + 1 )/ 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
								//North East
								findZone(((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1 )/ 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
							}



						}
						else
						{
							//north West
							//Filling up the L Shapes 
							grid[((xEnd - xStart + 1) / 2) - 1, ((yEnd - yStart + 1) / 2)] = count; //3,4 south west
							grid[((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2)] = count;//4,4 south east 
							grid[((xEnd - xStart + 1) / 2), ((yEnd - yStart + 1) / 2) - 1] = count;//4,3 north east 
							Console.WriteLine("North West");
							count++;
							if (xEnd - xStart > 0)
							{
								//North West 
								findZone(i, j, xStart, yStart, ((xEnd + 1) / 2) - 1, ((yEnd + 1) / 2) - 1, count, grid);
								// South West side 
								findZone(((xEnd - xStart + 1) / 2) - 1, ((yEnd - yStart + 1) / 2), xStart, ((yEnd + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yEnd, count, grid);
								//South East side 
								findZone(((xEnd - xStart + 1 )/ 2), ((yEnd - yStart + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
								//North East
								findZone(((xEnd - xStart + 1 )/ 2), ((yEnd - yStart + 1) / 2) - 1, ((xEnd + 1) / 2) - 1, yStart, xEnd, ((yEnd + 1) / 2) - 1, count, grid);
							}

						}
					}






				}
			}
		}
		//}
	}


