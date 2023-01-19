using System;
using System.Collections.Generic;

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
        string job1Concat = $"{job1._jobTitle} ({job1._companyName}) {job1._startYear} - {job1._endYear}";
        // figure out how to add this job to the list of jobs on the resume page... 
        //Resume.jobs.Add(job1);
        //job1.DisplayJob(); // this can be commented out once it's added to the resume

        Job job2;
        job2 = new Job();
        job2._jobTitle = "Implementation Manager";
        job2._companyName = "Ventris";
        job2._startYear = "2017";
        job2._endYear = "2018";
        string job2Concat = $"{job2._jobTitle} ({job2._companyName}) {job2._startYear} - {job2._endYear}";
        // job2.DisplayJob();

        Resume resume1;
        resume1 = new Resume();
        resume1._name = "Emily Mason";
        // add previous jobs to the list of jobs on the resume page, then display it... somehow...
        resume1.jobs.Add(job1Concat);
        resume1.jobs.Add(job2Concat);
        //Console.WriteLine($"{resume1._name}, {resume1.jobs[0]}, {resume1.jobs[1]}");
        resume1.DisplayResume();
    }

}