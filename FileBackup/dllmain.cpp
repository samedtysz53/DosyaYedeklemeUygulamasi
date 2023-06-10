#include <iostream>
#include <windows.h>
#include <string>
#include <filesystem>

int CountFiles(const std::string& directory)
{
    int count = 0;
    for (const auto& entry : std::filesystem::directory_iterator(directory))
    {
        if (entry.is_regular_file())
        {
            count++;
        }
        else if (entry.is_directory())
        {
            count += CountFiles(entry.path().string());
        }
    }
    return count;
}

void BackupFolders(const std::string& sourceFolder, const std::string& destinationFolder)
{
    try
    {
        for (const auto& entry : std::filesystem::directory_iterator(sourceFolder))
        {
            if (entry.is_regular_file())
            {
                std::string fileName = entry.path().filename().string();
                std::string destinationPath = destinationFolder + "\\" + fileName;

                if (!CopyFileA(entry.path().string().c_str(), destinationPath.c_str(), TRUE))
                {
                    throw std::runtime_error("Dosya kopyalanırken hata oluştu");
                }

                // İlerlemeyi güncelle
                filesProcessed++;
                progressBar.Value = filesProcessed;
                progreslbl.Text = std::to_string(progressBar.Value);
                int percentage = (int)((float)filesProcessed / totalFiles * 100);
                progreslbl.Text = std::to_string(percentage) + "%";//progressbar yüzdesini label da göster
                Application.DoEvents();
            }
            else if (entry.is_directory())
            {
                std::string directoryName = entry.path().filename().string();
                std::string destinationPath = destinationFolder + "\\" + directoryName;

                if (!CreateDirectoryA(destinationPath.c_str(), NULL))
                {
                    throw std::runtime_error("Dizin oluşturulurken hata oluştu");
                }

                // Alt dizini ve içeriğini yedekle
                BackupFolders(entry.path().string(), destinationPath);
            }
        }
    }
    catch (const std::exception& ex)
    {
        MessageBoxA(NULL, ("Hata oluştu: " + std::string(ex.what())).c_str(), NULL, MB_OK | MB_ICONERROR);
    }
}
