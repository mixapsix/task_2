﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Task_2
{
    class FilesSeeker
    {
        public string Directory { get; set; }
        public string FileMask { get; set; }
        public string Result { get ; set ; }
        public List<string> AllFiles {  get ; set ; }

        public void FilesInDirectory()
        {
            try
            {
                AllFiles = System.IO.Directory.GetFiles(Directory).ToList<string>(); ;
            }
            catch(DirectoryNotFoundException)
            {
                MessageBox.Show("Директория не найдена!");
            }

            try
            {
                foreach (string file in AllFiles)
                {
                    if (file.Contains(FileMask))
                    {
                        Result += file + "\n";
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Files not found");
            }
        }
    }
}
