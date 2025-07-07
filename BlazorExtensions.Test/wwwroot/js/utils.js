window.sessionStorageHelper = {

    getItem: function (key) {
        return sessionStorage.getItem(key);
    },

    // Sets an item in sessionStorage
    setItem: function (key, value) {
        sessionStorage.setItem(key, value);
    }
};

window.downloadHelper = {

    downloadFileFromStream: async function (fileName, contentStreamReference) {
        const arrayBuffer = await contentStreamReference.arrayBuffer();
        const blob = new Blob([arrayBuffer]);
        const url = URL.createObjectURL(blob);
        const anchorElement = document.createElement('a');
        anchorElement.href = url;
        anchorElement.download = fileName ?? '';
        anchorElement.click();
        anchorElement.remove();
        URL.revokeObjectURL(url);
    }
};