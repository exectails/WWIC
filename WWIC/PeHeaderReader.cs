namespace WWIC
{
	public class PEHeaderReader
	{
		const int PEHeaderOffset = 0x3C;
		const int TimeDateStampOffset = 0x04;
		const int PESignature = 0x00004550; // PE\0\0

		public static DateTime GetTimeDateStamp(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException($"File '{filePath}' not found.");

			using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (var reader = new BinaryReader(stream))
			{
				stream.Seek(PEHeaderOffset, SeekOrigin.Begin);
				var peHeaderPointer = reader.ReadInt32();
				stream.Seek(peHeaderPointer, SeekOrigin.Begin);

				var peSignature = reader.ReadUInt32();
				if (peSignature != PESignature)
					throw new InvalidOperationException("Not a valid PE file.");

				stream.Seek(TimeDateStampOffset, SeekOrigin.Current);
				var timeDateStamp = reader.ReadUInt32();

				var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timeDateStamp);

				return dateTime;
			}
		}
	}
}
