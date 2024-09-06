async function downloadFile(url, fileName) {
    try {
        const response = await fetch(url);
        const blob = await response.blob();
        const fileHandle = await window.showSaveFilePicker({
            suggestedName: fileName,
            types: [{
                description: 'HTML Files',
                accept: {
                    'text/html': ['.html']
                }
            }]
        });
        const writable = await fileHandle.createWritable();
        await writable.write(blob);
        await writable.close();
    } catch (e) {
        console.error(e);
    }
}