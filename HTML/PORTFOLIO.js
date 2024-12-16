function expandBlock(blockId) {
    const block = document.getElementById(blockId);
    const expandedView = document.getElementById('expandedView');
    const expandedImage = document.getElementById('expandedImage');
    const expandedTitle = document.getElementById('expandedTitle');
    const expandedDescription = document.getElementById('expandedDescription');

    // Example content: Replace with dynamic content if needed
    const backgroundImage = window.getComputedStyle(block).getPropertyValue('background-image');
    expandedImage.style.backgroundImage = backgroundImage;

    expandedView.classList.add('active');

    switch(block){
        case BL1:
             expandedTitle.textContent= "VHS 70s"
             expandedDescription.textContent="promotional VHS 2 mobile wallpaper \n a great noseq "
             break;
        case BL2:
            expandedTitle.textContent= "VHS GLITCH"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL3:
            expandedTitle.textContent= "VHS ART ADD POSTER"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL4:
            expandedTitle.textContent= "VHS-2 ENIGMA"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL5:
            expandedTitle.textContent= "WTF FILM POSTER"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL6:
            expandedTitle.textContent= "WHAT COULD GO WRONG POSTER"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL7:
            expandedTitle.textContent= "VHS2 OLD MAGAZINE"
            expandedDescription.textContent="NGNGNG"
            break;
        case BL8:
            expandedTitle.textContent= "BEAUTY IS PAIN WALLPAPER"
            expandedDescription.textContent="NGNGNG"
            break;
    }
}

function closeExpandedView() {
    const expandedView = document.getElementById('expandedView');
    expandedView.classList.remove('active');
}
