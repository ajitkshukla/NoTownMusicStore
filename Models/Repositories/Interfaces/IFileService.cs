﻿namespace NoTownMusicalStore.Models.Repositories.Interfaces
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}
