mergeInto(LibraryManager.library, {

  GetUserAgent: function () {
    var returnStr = navigator.userAgent;
    var bufferSize = lengthBytesUTF8(returnStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },

});