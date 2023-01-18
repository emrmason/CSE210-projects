class Program
{
    static void Main(string[] args)
    {
        Job job1;
        job1 = new Job();
        job1._jobTitle = "Customer Service Representative";
        job1._companyName= "Regence BCBS of Utah";
        job1._startYear = "2006";
        job1._endYear = "2017";
        job1.DisplayJob();

        Job job2;
        job2 = new Job();
        job2._jobTitle = "Implementation Manager";
        job2._companyName = "Ventris";
        job2._startYear = "2017";
        job2._endYear = "2018";
        job2.DisplayJob();
    }

}