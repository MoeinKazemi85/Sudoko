using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your table data:");
            string[,] cells = new string[9, 9];

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                string strCellsVertical = Console.ReadLine();
                for (int j = 0; j < cells.GetLength(1); j++)
                    cells[i, j] = strCellsVertical[j].ToString();
            }
            string[] positionZeroTmp = new string[9 * 9];
            for (int i = 0, k = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j] == "0")
                    {
                        positionZeroTmp[k] = string.Format("{0},{1}", i, j);
                        k++;
                    }
                }
            }
            Array.Sort(positionZeroTmp);
            int countNotNull = 0;
            for (int i = 0; i < positionZeroTmp.Length; i++)
            {
                if (positionZeroTmp[i] != null)
                {
                    countNotNull++;
                }
            }
            string[] positionZero = new string[countNotNull];
            for (int i = 0, j = 0; i < 81; i++)
            {
                if (!(positionZeroTmp[i] is null))
                {

                    positionZero[j] = positionZeroTmp[i].ToString();
                    j++;
                }
            }

            Console.WriteLine("======================");
            #region districts

            //District 1~9 123
            //             456
            //             789
            string[,] District1 = new string[3, 3];
            string[,] District2 = new string[3, 3];
            string[,] District3 = new string[3, 3];
            string[,] District4 = new string[3, 3];
            string[,] District5 = new string[3, 3];
            string[,] District6 = new string[3, 3];
            string[,] District7 = new string[3, 3];
            string[,] District8 = new string[3, 3];
            string[,] District9 = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < District1.GetLength(0); j++)
                {
                    District1[i, j] = cells[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 3, k = 0; j < 6 && k < District2.GetLength(0); j++, k++)
                {
                    District2[i, k] = cells[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 6, k = 0; j < 9 && k < District3.GetLength(0); j++, k++)
                {
                    District3[i, k] = cells[i, j];
                }
            }
            for (int i = 3, l = 0; i < 6; i++, l++)
            {
                for (int j = 0, k = 0; j < 3 && k < District4.GetLength(0); j++, k++)
                {
                    District4[l, k] = cells[i, j];
                }
            }
            for (int i = 3, l = 0; i < 6; i++, l++)
            {
                for (int j = 3, k = 0; j < 6 && k < District5.GetLength(0); j++, k++)
                {
                    District5[l, k] = cells[i, j];
                }
            }
            for (int i = 3, l = 0; i < 6; i++, l++)
            {
                for (int j = 6, k = 0; j < 9 && k < District6.GetLength(0); j++, k++)
                {
                    District6[l, k] = cells[i, j];
                }
            }
            for (int i = 6, l = 0; i < 9; i++, l++)
            {
                for (int j = 0, k = 0; j < 3 && k < District7.GetLength(0); j++, k++)
                {
                    District7[l, k] = cells[i, j];
                }
            }
            for (int i = 6, l = 0; i < 9; i++, l++)
            {
                for (int j = 3, k = 0; j < 6 && k < District8.GetLength(0); j++, k++)
                {
                    District8[l, k] = cells[i, j];
                }
            }
            for (int i = 6, l = 0; i < 9; i++, l++)
            {
                for (int j = 6, k = 0; j < 9 && k < District9.GetLength(0); j++, k++)
                {
                    District9[l, k] = cells[i, j];
                }
            }

            #endregion
            #region Rows
            //1~9

            string[] row1 = new string[9];
            string[] row2 = new string[9];
            string[] row3 = new string[9];
            string[] row4 = new string[9];
            string[] row5 = new string[9];
            string[] row6 = new string[9];
            string[] row7 = new string[9];
            string[] row8 = new string[9];
            string[] row9 = new string[9];
            for (int i = 0; i < 9; i++)
            {
                row1[i] = cells[0, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row2[i] = cells[1, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row3[i] = cells[2, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row4[i] = cells[3, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row5[i] = cells[4, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row6[i] = cells[5, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row7[i] = cells[6, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row8[i] = cells[7, i];
            }
            for (int i = 0; i < 9; i++)
            {
                row9[i] = cells[8, i];
            }
            #endregion
            #region Cols
            //1~9
            string[] col1 = new string[9];
            string[] col2 = new string[9];
            string[] col3 = new string[9];
            string[] col4 = new string[9];
            string[] col5 = new string[9];
            string[] col6 = new string[9];
            string[] col7 = new string[9];
            string[] col8 = new string[9];
            string[] col9 = new string[9];
            for (int i = 0; i < 9; i++)
            {
                col1[i] = cells[i, 0];
            }
            for (int i = 0; i < 9; i++)
            {
                col2[i] = cells[i, 1];
            }
            for (int i = 0; i < 9; i++)
            {
                col3[i] = cells[i, 2];
            }
            for (int i = 0; i < 9; i++)
            {
                col4[i] = cells[i, 3];
            }
            for (int i = 0; i < 9; i++)
            {
                col5[i] = cells[i, 4];
            }
            for (int i = 0; i < 9; i++)
            {
                col6[i] = cells[i, 5];
            }
            for (int i = 0; i < 9; i++)
            {
                col7[i] = cells[i, 6];
            }
            for (int i = 0; i < 9; i++)
            {
                col8[i] = cells[i, 7];
            }
            for (int i = 0; i < 9; i++)
            {
                col9[i] = cells[i, 8];
            }
            #endregion
            string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool[] flag = new bool[9];
            #region FillNotExistNumber
            #region District1
            //fill flag order by number is not exist in row 1
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row1[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }

            string numbersNotExistRow1 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow1 += (i + 1).ToString();
                }
            }
            //================================================
            //fill flag order by number is not exist in Col 1
            string numbersNotExistCol1 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col1[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol1 += (i + 1).ToString();
                }
            }
            //================================================
            //fill flag order by number is not exist in 3*3 destrict1
            ResetFlag(flag);
            for (int i = 0; i < District1.GetLength(0); i++)
            {
                for (int j = 0; j < District1.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District1[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict1 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict1 += (i + 1).ToString();
                }
            }
            //=======================================================
            #endregion
            #region District2
            //fill flag order by number is not exist in row 2
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row2[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow2 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow2 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 2
            ResetFlag(flag);
            string numbersNotExistCol2 = null;
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col2[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol2 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict2
            ResetFlag(flag);
            for (int i = 0; i < District2.GetLength(0); i++)
            {
                for (int j = 0; j < District2.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District2[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict2 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict2 += (i + 1).ToString();
                }
            }
            #endregion
            #region District3
            //fill flag order by number is not exist in row 2
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row3[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow3 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow3 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 2
            ResetFlag(flag);
            string numbersNotExistCol3 = null;
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col3[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol3 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict2
            ResetFlag(flag);
            for (int i = 0; i < District3.GetLength(0); i++)
            {
                for (int j = 0; j < District3.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District3[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict3 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict3 += (i + 1).ToString();
                }
            }
            #endregion
            #region District4
            //fill flag order by number is not exist in row 2
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row4[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow4 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow4 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 2
            string numbersNotExistCol4 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col4[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol4 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict2
            ResetFlag(flag);
            for (int i = 0; i < District4.GetLength(0); i++)
            {
                for (int j = 0; j < District4.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District4[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict4 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict4 += (i + 1).ToString();
                }
            }
            #endregion
            #region District5
            //fill flag order by number is not exist in row 5
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row5[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow5 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow5 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 5
            string numbersNotExistCol5 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col5[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol5 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict5
            ResetFlag(flag);
            for (int i = 0; i < District5.GetLength(0); i++)
            {
                for (int j = 0; j < District5.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District5[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict5 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict5 += (i + 1).ToString();
                }
            }
            #endregion
            #region District6
            //fill flag order by number is not exist in row 6
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row6[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow6 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow6 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 6
            string numbersNotExistCol6 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col6[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol6 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict6
            ResetFlag(flag);
            for (int i = 0; i < District6.GetLength(0); i++)
            {
                for (int j = 0; j < District6.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District6[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict6 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict6 += (i + 1).ToString();
                }
            }
            #endregion
            #region District7
            //fill flag order by number is not exist in row 7
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row7[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow7 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow7 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 7
            string numbersNotExistCol7 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col7[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol7 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict7
            ResetFlag(flag);
            for (int i = 0; i < District7.GetLength(0); i++)
            {
                for (int j = 0; j < District7.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District7[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict7 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict7 += (i + 1).ToString();
                }
            }
            #endregion
            #region District8
            //fill flag order by number is not exist in row 8
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row8[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow8 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow8 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 8
            string numbersNotExistCol8 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col8[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol8 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict8
            ResetFlag(flag);
            for (int i = 0; i < District8.GetLength(0); i++)
            {
                for (int j = 0; j < District8.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District8[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict8 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict8 += (i + 1).ToString();
                }
            }
            #endregion
            #region District9
            //fill flag order by number is not exist in row 9
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (row9[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            string numbersNotExistRow9 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistRow9 += (i + 1).ToString();
                }
            }
            //=======================================================
            //fill flag order by number is not exist in Col 9
            string numbersNotExistCol9 = null;
            ResetFlag(flag);
            for (int i = 0, k = 0; i < numbers.Length; i++, k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    if (col9[k] == numbers[j])
                    {
                        flag[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistCol9 += (i + 1).ToString();
                }
            }
            //===================================================
            //fill flag order by number is not exist in 3*3 destrict9
            ResetFlag(flag);
            for (int i = 0; i < District9.GetLength(0); i++)
            {
                for (int j = 0; j < District9.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        for (int l = 0; l < 9; l++)
                        {
                            if (District9[i, j] == numbers[l])
                            {
                                flag[l] = true;
                                break;
                            }
                        }
                    }
                }
            }
            string numbersNotExistDistrict9 = null;
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == false)
                {
                    numbersNotExistDistrict9 += (i + 1).ToString();
                }
            }
            #endregion
            #endregion
            #region FindCommon  District1
            string common11 = findCommon(numbersNotExistRow1.ToCharArray(), numbersNotExistCol1.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common12 = findCommon(numbersNotExistRow1.ToCharArray(), numbersNotExistCol2.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common13 = findCommon(numbersNotExistRow1.ToCharArray(), numbersNotExistCol3.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common21 = findCommon(numbersNotExistRow2.ToCharArray(), numbersNotExistCol1.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common22 = findCommon(numbersNotExistRow2.ToCharArray(), numbersNotExistCol2.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common23 = findCommon(numbersNotExistRow2.ToCharArray(), numbersNotExistCol3.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common31 = findCommon(numbersNotExistRow3.ToCharArray(), numbersNotExistCol1.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common32 = findCommon(numbersNotExistRow3.ToCharArray(), numbersNotExistCol2.ToCharArray(), numbersNotExistDistrict1.ToCharArray());
            string common33 = findCommon(numbersNotExistRow3.ToCharArray(), numbersNotExistCol3.ToCharArray(), numbersNotExistDistrict1.ToCharArray());

            #endregion


            Console.ReadKey();
        }
        public static void ResetFlag(bool[] flag)
        {
            for (int i = 0; i < flag.Length; i++)
            {
                flag[i] = false;
            }
        }
        static string findCommon(char[] ar1, char[] ar2, char[] ar3)

        {
            string resualt = null;
            // Initialize starting indexes for
            // ar1[], ar2[] and ar3[]
            int i = 0, j = 0, k = 0;

            // Iterate through three arrays while
            // all arrays have elements
            while (i < ar1.Length && j < ar2.Length
                                  && k < ar3.Length)
            {

                // If x = y and y = z, print any of
                // them and move ahead in all arrays
                if (ar1[i] == ar2[j] &&
                                   ar2[j] == ar3[k])
                {
                    resualt += ar1[i];
                    i++;
                    j++;
                    k++;
                }

                // x < y
                else if (ar1[i] < ar2[j])
                    i++;

                // y < z
                else if (ar2[j] < ar3[k])
                    j++;

                // We reach here when x > y and
                // z < y, i.e., z is smallest
                else
                    k++;
            }
            return resualt;
        }
    }
}
