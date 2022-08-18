using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace iCertisInterviewPrep
{
    public class Program
    {
        #region Icertis inverview Question
        //public class ProductInfo
        //{
        //    public string ProductName { get; set; }
        //    public string LibraryName { get; set; }
        //    public string Version { get; set; }
        //}
        //public static List<string> processData(
        //                                IEnumerable<string> lines)
        //{
        //    /* 
        //     * Do not make any changes outside this method.
        //     *
        //     * Modify this method to process `array` as indicated
        //     * in the question. At the end, return a List containing
        //     * the appropriate values
        //     *
        //     * Do not print anything in this method
        //     *
        //     * Submit this entire program (not just this function)
        //     * as your answer
        //     */
        //    var productInfoList = new List<ProductInfo>();


        //    var abc = (from nod in lines
        //               select new
        //               {
        //                   customerName = nod.Split(',')[0].Trim(),
        //                   location = nod.Split(',')[1].Trim(),
        //                   APIName = nod.Split(',')[2].Trim(),
        //                   APIlevel= nod.Split(',')[3].Trim(),
        //                   level = Convert.ToInt32(Regex.Replace(nod.Split(',')[3].Trim(), @"[^\d]", ""))
        //               });
        //    var maxVersion = abc.GroupBy(a => a.APIName).ToList();

        //    foreach (var item in maxVersion)
        //    {
        //        //Func<string> anyCarDoesNotHaveDoor = () => {
        //        //    foreach (var obj in abc)
        //        //        if (obj. == null)
        //        //            return ;
        //        //    return false;
        //        //};
        //        var bc = abc.Where(w => w.APIName == item.Key);//.Select(s => s.customerName).OrderByDescending(o => o).FirstOrDefault();

        //        if (bc.Select(s=>s.APIlevel).Distinct().Count() > 1)
        //        {

        //            var rr = bc.Where(w => w.level == bc.Min(x => x.level)).Select(s => s.customerName).FirstOrDefault();

        //            var teamBestScores = (from player in bc
        //                                 group player by player.APIName into playerGroup
        //                                 select new
        //                                 {
        //                                     Team = playerGroup.Key,
        //                                     BestScore = playerGroup.Min(x => x.level),
        //                                     name = playerGroup.Where(w=>w.level == playerGroup.Min(x => x.level)).Select(s=>s.customerName).FirstOrDefault(),
        //                                 }).ToList();


        //            //var aa = (from ob in bc
        //            //          where 
        //            //          select new { name = ob.customerName, level =  ob.level });
        //        }
        //    }

        //    //foreach (var item in lines)
        //    //{
        //    //    ProductInfo details = new ProductInfo();
        //    //    var split = item.Split(',');
        //    //    details.ProductName = split[0];
        //    //    details.LibraryName = split[1];
        //    //    details.Version = split[2];
        //    //    productInfoList.Add(details);
        //    //}

        //    //var versionMaxList = productInfoList.GroupBy(g => new { g.LibraryName }).Select(x => new { maxVersion = x.Max(g => g.Version), LibName = x.Key.LibraryName });
        //    //var list2 = (from pdl in productInfoList
        //    //             join vl in versionMaxList
        //    //             on pdl.Version equals vl.maxVersion
        //    //             //where pdl.LibraryName != vl.LibName
        //    //             select new { pdl.LibraryName, pdl.Version, pdl.ProductName });
        //    //List<string> retVal = new List<string>();

        //    //foreach (var item in list2)
        //    //{
        //    //    if (!retVal.Contains(item.ProductName))
        //    //    {
        //    //        if (retVal.Count > 1)
        //    //            break;
        //    //        retVal.Add(item.ProductName);
        //    //    }
        //    //}
        //    return null;
        //}

        #endregion

        #region Turing Interview Question
        //public int[] findErrorNums(int[] nums)
        //{
        //    int[] res = new int[2];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int idx = Math.Abs(nums[i]) - 1;
        //        if (nums[idx] > 0) nums[idx] = -nums[idx];
        //        else res[0] = idx + 1;
        //    }
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] < 0) nums[i] = -nums[i];
        //        else res[1] = i + 1;
        //    }
        //    return res;
        //}
        #endregion


        
        static void Main(string[] args)
        {
            try
            {
                 var aa=  ModifyVariableName("this_is_a_variable");
                var aaa = ModifyVariableName("thisIsAVariable");
                var aaad = ModifyVariableName("modify_vaiableName");
                //Array list to store all the duplicate values

              
                Console.WriteLine("The numbers which duplicates are");
               var avas= DisplayArray();
                Console.ReadLine();
                //string line;
                //var inputLines = new List<string>();
                ////while ((line = Console.ReadLine()) != null)
                ////{
                ////    line = line.Trim();
                ////    if (line != "")
                ////        inputLines.Add(line);
                ////}
                //inputLines.Add("RP Solutions, Australia, Cloud Telephony, Level 7");
                //inputLines.Add("Marketrac Inc, Baharain, Machine Learning, Level 9");
                //inputLines.Add("RP Solutions, Australia, Machine Learning, Level 10");
                //inputLines.Add("NewScore, Baharain, Auth API, Level 5");
                //inputLines.Add("Sun Fintech, Sweden, Auth API, Level 6");
                //inputLines.Add("RG.com, Australia, Email API, Level 10");
                //inputLines.Add("RP Solutions, Sweden, Auth API, Level 6");
                //inputLines.Add("RP Solutions, Australia, Storage, Level 3");
                //inputLines.Add("FPRP Solutions, Baharain, Storage, Level 2");
                //inputLines.Add("NewScore, Baharain, Storage, Level 4");
                //inputLines.Add("Marketrac Inc, Baharain, Storage, Level 3");

                //var retVal = processData(inputLines);
                //foreach (var res in retVal.OrderBy(o => o))
                //    Console.WriteLine(res);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
