async function downloadPortfolioAsPDF(elementId, pdfName) {
    const element = document.getElementById(elementId);
    if (!element) {
        console.error("Element not found:", elementId);
        return;
    }

    const DPI = 150;
    const A4_WIDTH_IN = 8.27;
    const A4_WIDTH_PX = A4_WIDTH_IN * DPI; // ~1240 px

    // Measure element
    const rect = element.getBoundingClientRect();
    const scale = A4_WIDTH_PX / rect.width;

    // Backup styles
    const original = {
        transform: element.style.transform,
        transformOrigin: element.style.transformOrigin,
        width: element.style.width
    };

    element.style.transformOrigin = "top left";
    element.style.transform = `scale(${scale})`;
    element.style.width = rect.width + "px";

    await new Promise(r => requestAnimationFrame(r));

    // Render element
    const canvas = await html2canvas(element, {
        scale: DPI / 96,
        useCORS: true,
        scrollY: 0,
        backgroundColor: null
    });

    // --- TRIM WHITE SPACE ---
    const ctx = canvas.getContext('2d');
    const imgData = ctx.getImageData(0, 0, canvas.width, canvas.height);
    let top = null, bottom = null;

    // detect content boundaries
    for (let y = 0; y < canvas.height; y++) {
        for (let x = 0; x < canvas.width; x++) {
            const alpha = imgData.data[(y * canvas.width + x) * 4 + 3];
            if (alpha > 0) {
                if (top === null) top = y;
                bottom = y;
                break;
            }
        }
    }

    const contentHeight = bottom - top + 1;

    // Create cropped canvas
    const trimmedCanvas = document.createElement("canvas");
    trimmedCanvas.width = canvas.width;
    trimmedCanvas.height = contentHeight;
    trimmedCanvas
        .getContext("2d")
        .drawImage(canvas, 0, top, canvas.width, contentHeight, 0, 0, canvas.width, contentHeight);

    const finalImgData = trimmedCanvas.toDataURL("image/jpeg", 1.0);

    // --- Generate PDF dynamically ---
    const pdfWidthPt = A4_WIDTH_IN * 72;
    const pdfHeightPt = (trimmedCanvas.height * pdfWidthPt) / trimmedCanvas.width;

    const pdf = new jspdf.jsPDF({
        orientation: "p",
        unit: "pt",
        format: [pdfWidthPt, pdfHeightPt]
    });

    pdf.addImage(finalImgData, "JPEG", 0, 0, pdfWidthPt, pdfHeightPt);
    pdf.save(pdfName + ".pdf");

    // Restore styles
    element.style.transform = original.transform;
    element.style.transformOrigin = original.transformOrigin;
    element.style.width = original.width;
}
