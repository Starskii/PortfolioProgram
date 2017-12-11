using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class InitializeData
    {
        #region ObjectList
        static List<ProjectExecutables> projectExecutables = new List<ProjectExecutables>
        {
            new ProjectExecutables
            {
                FileName = FileName.listPractice,
                FilePath = @"Resources\Programs\ListStuff.exe",
                FileDescription = "Practice with using Lists in C#"
            },
            new ProjectExecutables
            {
                FileName = FileName.switchStatement,
                FilePath = @"Resources\Programs\switchStatement.exe",
                FileDescription = "ITTSSS THE HULKINATOR CALCULATOR CALCOTRON 10 TRILLION BABY OOHHHH YEAAAHHHH"
            },
            new ProjectExecutables
            {
                FileName = FileName.Calculator,
                FilePath = @"Resources\Programs\TheCalculator.exe",
                FileDescription = "A simple calculator that can add, subtract, divide and multiply."
            },
            new ProjectExecutables
            {
                FileName = FileName.IamBroken,
                FilePath = @"Resources\Programs\HelloWorld.exe",
                FileDescription = "An example of how my program handles attempting to launch a file that does not exist. If left unhandled, it would crash the program."
            }

        };
        #endregion

        #region Methods
        public ProjectExecutables FindActiveObject(FileName fileName)
        {
            ProjectExecutables activeObject = new ProjectExecutables();
            foreach (ProjectExecutables item in projectExecutables)
            {
                if (item.FileName == fileName)
                {
                    activeObject = item;
                }
                else
                {

                }
            }
            return activeObject;
        }
        #endregion
    }
}
