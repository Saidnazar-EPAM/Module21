using Module21.Interfaces;
using System.IO;
using System.Text.Json;
using Module21.Models;

namespace Module21
{
    public class FindInFileSystem : IFindDocument
    {
        private readonly string _path;
        private readonly string _documentTypesNamespace;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Path to folder containing documents.</param>
        /// <param name="documentTypesNamespace">Namespace of document-type models.</param>
        public FindInFileSystem(string path, string documentTypesNamespace)
        {
            _path = path;
            _documentTypesNamespace = documentTypesNamespace;
        }

        public IEnumerable<string> FindByNumber(int number)
        {
            var searchPattern = $"*_{number}.json";
            var fileFullNames = Directory.EnumerateFiles(_path, searchPattern);
            foreach (var fileFullName in fileFullNames)
            {
                var documnetObject = GetObject(fileFullName);
                if (documnetObject is not IDocument)
                    throw new Exception($"Document type is not IDocument. Filename: {fileFullName}");

                var document = documnetObject as IDocument;
                document!.Number = number;
                yield return document!.ToString()!;
            }
        }

        private object GetObject(string fileFullName)
        {
            var fileContent = File.ReadAllText(fileFullName);
            var documentType = GetDocumentType(fileFullName);
            var documentObject = JsonSerializer.Deserialize(fileContent, documentType);
            return documentObject!;
        }

        private Type GetDocumentType(string fileFullName)
        {
            var typeName = GetDocumentTypeName(fileFullName);
            if (string.IsNullOrWhiteSpace(typeName))
                throw new Exception("There is no type name in the filename.");

            var typeFullName = _documentTypesNamespace + "." + typeName;
            var type = Type.GetType(typeFullName);

            if (type == null)
                throw new Exception($"Type not found. Filename: {fileFullName}");

            return type;
        }

        private string GetDocumentTypeName(string fileFullName)
        {
            var fileName = Path.GetFileNameWithoutExtension(fileFullName);

            if (fileName.Count(b => b == '_') > 1)
                throw new Exception("There is more than one underscore in the filename.");

            var indexOfUnderscore = fileName.IndexOf('_');
            return fileName.Substring(0, indexOfUnderscore);
        }
    }
}
