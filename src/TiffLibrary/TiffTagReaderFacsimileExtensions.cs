﻿using System.Threading.Tasks;

namespace TiffLibrary
{
    public static partial class TiffTagReaderExtensions
    {
    
        #region BadFaxLines

        /// <summary>
        /// Read the values of <see cref="TiffTag.BadFaxLines"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>A <see cref="ValueTask{TiffValueCollection}"/> that completes when the value of the tag is read and return the read values.</returns>
        public static ValueTask<uint> ReadBadFaxLinesAsync(this TiffTagReader tagReader)
        {
            ValueTask<TiffValueCollection<uint>> valueTask = tagReader.ReadLongFieldAsync(TiffTag.BadFaxLines);
            if (valueTask.IsCompletedSuccessfully)
            {
                TiffValueCollection<uint> result = valueTask.GetAwaiter().GetResult();
                return new ValueTask<uint>(result.GetFirstOrDefault());
            }

            return new ValueTask<uint>(TransformValueTaskAsync(valueTask));

            static async Task<uint> TransformValueTaskAsync(ValueTask<TiffValueCollection<uint>> valueTask)
            {
                TiffValueCollection<uint> result = await valueTask.ConfigureAwait(false);
                return result.GetFirstOrDefault();
            }
        }
        
        /// <summary>
        /// Read the values of <see cref="TiffTag.BadFaxLines"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>The values read.</returns>
        public static uint ReadBadFaxLines(this TiffTagReader tagReader)
        {
            TiffValueCollection<uint> result = tagReader.ReadLongField(TiffTag.BadFaxLines);
            return result.GetFirstOrDefault();
        }

        #endregion
    
        #region CleanFaxData

        /// <summary>
        /// Read the values of <see cref="TiffTag.CleanFaxData"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>A <see cref="ValueTask{TiffValueCollection}"/> that completes when the value of the tag is read and return the read values.</returns>
        public static ValueTask<TiffCleanFaxData> ReadCleanFaxDataAsync(this TiffTagReader tagReader)
        {
            ValueTask<TiffValueCollection<ushort>> valueTask = tagReader.ReadShortFieldAsync(TiffTag.CleanFaxData);
            if (valueTask.IsCompletedSuccessfully)
            {
                TiffValueCollection<ushort> result = valueTask.GetAwaiter().GetResult();
                return new ValueTask<TiffCleanFaxData>((TiffCleanFaxData)result.GetFirstOrDefault());
            }

            return new ValueTask<TiffCleanFaxData>(TransformValueTaskAsync(valueTask));

            static async Task<TiffCleanFaxData> TransformValueTaskAsync(ValueTask<TiffValueCollection<ushort>> valueTask)
            {
                TiffValueCollection<ushort> result = await valueTask.ConfigureAwait(false);
                return (TiffCleanFaxData)result.GetFirstOrDefault();
            }
        }
        
        /// <summary>
        /// Read the values of <see cref="TiffTag.CleanFaxData"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>The values read.</returns>
        public static TiffCleanFaxData ReadCleanFaxData(this TiffTagReader tagReader)
        {
            TiffValueCollection<ushort> result = tagReader.ReadShortField(TiffTag.CleanFaxData);
            return (TiffCleanFaxData)result.GetFirstOrDefault();
        }

        #endregion
    
        #region ConsecutiveBadFaxLines

        /// <summary>
        /// Read the values of <see cref="TiffTag.ConsecutiveBadFaxLines"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>A <see cref="ValueTask{TiffValueCollection}"/> that completes when the value of the tag is read and return the read values.</returns>
        public static ValueTask<uint> ReadConsecutiveBadFaxLinesAsync(this TiffTagReader tagReader)
        {
            ValueTask<TiffValueCollection<uint>> valueTask = tagReader.ReadLongFieldAsync(TiffTag.ConsecutiveBadFaxLines);
            if (valueTask.IsCompletedSuccessfully)
            {
                TiffValueCollection<uint> result = valueTask.GetAwaiter().GetResult();
                return new ValueTask<uint>(result.GetFirstOrDefault());
            }

            return new ValueTask<uint>(TransformValueTaskAsync(valueTask));

            static async Task<uint> TransformValueTaskAsync(ValueTask<TiffValueCollection<uint>> valueTask)
            {
                TiffValueCollection<uint> result = await valueTask.ConfigureAwait(false);
                return result.GetFirstOrDefault();
            }
        }
        
        /// <summary>
        /// Read the values of <see cref="TiffTag.ConsecutiveBadFaxLines"/>.
        /// </summary>
        /// <param name="tagReader">The tag reader to use.</param>
        /// <returns>The values read.</returns>
        public static uint ReadConsecutiveBadFaxLines(this TiffTagReader tagReader)
        {
            TiffValueCollection<uint> result = tagReader.ReadLongField(TiffTag.ConsecutiveBadFaxLines);
            return result.GetFirstOrDefault();
        }

        #endregion
    
    }
}