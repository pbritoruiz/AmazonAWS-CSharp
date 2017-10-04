using System;
using System.IO;

using Amazon.S3;
using Amazon.S3.Model;

namespace S3Upload
{
    public class AmazonS3Uploader
    {
        public void UploadFile(String path)
        {
            using (IAmazonS3 s3Client = Amazon.AWSClientFactory.CreateAmazonS3Client(
                    "MY ACCESS KEY", "MY SECRET ACCESS KEY", Amazon.RegionEndpoint.USEast1))
            {
                PutObjectRequest request = new PutObjectRequest();

                request.BucketName = "s3uploadcsharp";
                request.CannedACL = S3CannedACL.PublicRead;
                request.Key = Path.GetFileName(path);
                request.FilePath = path;

                s3Client.PutObject(request);
            }
        }
    }
}
