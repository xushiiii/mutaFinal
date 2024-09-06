function updateFileName(inputId, labelId) {
    var input = document.getElementById(inputId);
    var label = document.getElementById(labelId);
    input.addEventListener('change', function () {
        var fileName = input.files.length > 0 ? input.files[0].name : 'Choose File';
        label.textContent = fileName;
    });
}