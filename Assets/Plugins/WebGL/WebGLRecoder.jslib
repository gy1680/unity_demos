const WebGLRecoder = {
    $sharedInstance: {
        
    },
	HelloString: function (str) {
		window.alert(Pointer_stringify(str));
	},
};
autoAddDeps(WebGLRecoder, "$sharedInstance"),
mergeInto(LibraryManager.library, WebGLRecoder);