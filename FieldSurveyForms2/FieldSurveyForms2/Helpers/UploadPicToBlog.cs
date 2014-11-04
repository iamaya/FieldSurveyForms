using System;

namespace FieldSurveyForms2
{
	public class UploadPicToBlog
	{
		public UploadPicToBlog ()
		{
		}

		public string SavePic()
		{
			return "";
			//var image = new WebImage(file.InputStream);
			//double ratio = (double)image.Height / (double)image.Width;
			//image.Resize(800, (int)(800 * ratio));

//			int actualWidth = image.Width;
//			int actualHeight = image.Height;
//			if (image.Width > picWidth) actualWidth = picWidth;
//			if (actualHeight > picHeight) actualHeight = picHeight;
//			if (image.Width != actualWidth || actualHeight != image.Height)
//			{
//				image.Resize(actualWidth, actualHeight, false, false);
//			}
//
//
//			BlobHelper blobhelper = new BlobHelper();
//			//Create Temp folder on Azure blob
//			var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["StorageConnection"].ConnectionString);
//			var blobStorage = storageAccount.CreateCloudBlobClient();
//			CloudBlobContainer container1 = blobStorage.GetContainerReference(ConfigurationManager.AppSettings["BlobContainer"].ToString());
//			CloudBlobContainer container = blobhelper.getCloudBlobContainer(container1, 5);
//
//			CloudBlockBlob blob = container.GetBlockBlobReference(file.FileName);
//			blob.Properties.ContentType = file.ContentType;
//
//			blob.UploadFromByteArray(image.GetBytes(), 0, image.GetBytes().GetUpperBound(0));
//
//			return Path.Combine(blobpath, file.FileName);
		}
	}
}

