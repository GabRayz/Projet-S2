mergeInto(LibraryManager.library, {
    GetUsername: function () {
        console.log("get username");
        var username = JSON.parse(localStorage.user).username;
        
        var buffer = _malloc(lengthBytesUTF8(username) + 1);
        writeStringToMemory(username, buffer);
        return buffer;
    }
});