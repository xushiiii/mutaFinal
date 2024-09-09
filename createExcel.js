/*
window.createExcelFile = (data) => {
    const wb = XLSX.utils.book_new();
    const ws_data = [
        ["Overall Mutagenesis Rate", data.name1], 
        ["1-BP INSERTION PROFILE"],
        ["1-bp Insertion Rate", data.name2],
        ["A Insertion Rate", data.name3],
        ["T Insertion Rate", data.name4],
        ["C Insertion Rate", data.name5],
        ["G Insertion Rate", data.name6],
        ["Templated 1-bp Insertion Rate", data.name7],
        ["Non-Templated 1-bp Insertion Rate", data.name8],
        ["Small Deletion Rate", data.name9],
        ["1-bp Deletion Rate", data.name10],
        ["2-bp Deletion Rate", data.name11],
        ["3-bp Deletion Rate", data.name12],
        ["4-bp Deletion Rate", data.name13],
        ["5-bp Deletion Rate", data.name14],
        ["6-bp Deletion Rate", data.name15],
        ["7-bp Deletion Rate", data.name16],
        ["8-bp Deletion Rate", data.name17],
        ["9-bp Deletion Rate", data.name18],
        ["10-bp Deletion Rate", data.name19],
        ["1 Deletion Rate", data.name20],
        ["2 Deletion Rate", data.name21],
        ["3 Deletion Rate", data.name22],
        ["4 Deletion Rate", data.name23],
        ["5 Deletion Rate", data.name24],
        ["6 Deletion Rate", data.name25],
        ["7 Deletion Rate", data.name26],
        ["8 Deletion Rate", data.name27],
        ["9 Deletion Rate", data.name28],
        ["10 Deletion Rate", data.name29],
        ["1 Insertion Rate", data.name30],
        ["2 Insertion Rate", data.name31],
        ["3 Insertion Rate", data.name32]
    ];
    const ws = XLSX.utils.aoa_to_sheet(ws_data);
    ws['A2'].s = {
        font: { bold: true, sz: 14 } // Make text bold and set size
    };
    ws['!cols'] = [
        { wpx: 200 }, // "Overall Mutagenesis Rate" column width in pixels
        { wpx: 150 }  // "Name" column width in pixels
    ];
    XLSX.utils.book_append_sheet(wb, ws, "Sample Data");

    const wbout = XLSX.write(wb, { bookType: 'xlsx', type: 'binary' });
    const buf = new ArrayBuffer(wbout.length); // create a buffer
    const view = new Uint8Array(buf);  // create a view into the buffer
    for (let i = 0; i != wbout.length; ++i) view[i] = wbout.charCodeAt(i) & 0xFF;
    const blob = new Blob([buf], { type: "application/octet-stream" });

    const url = window.URL.createObjectURL(blob);
    const anchor = document.createElement('a');
    anchor.href = url;
    anchor.download = "SampleData.xlsx";
    anchor.click();
    window.URL.revokeObjectURL(url);
};
*/
// wwwroot/js/excelHelper.js

// wwwroot/js/excelHelper.js

async function createExcelFile(data)
{
    const ExcelJS = window.ExcelJS;
    const workbook = new ExcelJS.Workbook();
    const worksheet = workbook.addWorksheet('Sample Data');

    // Data for the worksheet
    const ws_data = [
        ["Overall Mutagenesis Rate", data.name1],
        ["1-BP INSERTION PROFILE"],
        ["1-bp Insertion Rate", data.name2],
        ["A Insertion Rate", data.name3],
        ["T Insertion Rate", data.name4],
        ["C Insertion Rate", data.name5],
        ["G Insertion Rate", data.name6],
        ["Templated 1-bp Insertion Rate", data.name7],
        ["Non-Templated 1-bp Insertion Rate", data.name8],
        ["DELETION PROFILE"],
        ["Small Deletion Rate", data.name9],
        ["1-bp Deletion Rate", data.name10],
        ["2-bp Deletion Rate", data.name11],
        ["3-bp Deletion Rate", data.name12],
        ["4-bp Deletion Rate", data.name13],
        ["5-bp Deletion Rate", data.name14],
        ["6-bp Deletion Rate", data.name15],
        ["7-bp Deletion Rate", data.name16],
        ["8-bp Deletion Rate", data.name17],
        ["9-bp Deletion Rate", data.name18],
        ["10-bp Deletion Rate", data.name19],
        ["NORMALIZED INDEL RATE"],
        ["1-bp Deletion Rate", data.name20],
        ["2-bp Deletion Rate", data.name21],
        ["3-bp Deletion Rate", data.name22],
        ["4-bp Deletion Rate", data.name23],
        ["5-bp Deletion Rate", data.name24],
        ["6-bp Deletion Rate", data.name25],
        ["7-bp Deletion Rate", data.name26],
        ["8-bp Deletion Rate", data.name27],
        ["9-bp Deletion Rate", data.name28],
        ["10-bp Deletion Rate", data.name29],
        ["1-bp Insertion Rate", data.name30],
        ["2-bp Insertion Rate", data.name31],
        ["3-bp Insertion Rate", data.name32]
    ];

    // Add rows to the worksheet
    ws_data.forEach(row => worksheet.addRow(row));

    // Apply styling to the specific rows and cells
    worksheet.getCell('A2').font = { bold: true, size: 16 }; // "1-BP INSERTION PROFILE" is bold and font size 16
    worksheet.getCell('A10').font = { bold: true, size: 16 };
    worksheet.getCell('A22').font = { bold: true, size: 16 };


    // Set column widths
    worksheet.columns = [
        { width: 40 }, // Width for the first column
        { width: 30 }  // Width for the second column
    ];

    // Generate buffer and initiate download
    const buffer = await workbook.xlsx.writeBuffer();
    const blob = new Blob([buffer], { type: "application/octet-stream" });
const url = window.URL.createObjectURL(blob);
const anchor = document.createElement('a');
anchor.href = url;
anchor.download = "MutagenesisProfileReport.xlsx";
anchor.click();
window.URL.revokeObjectURL(url);
}



