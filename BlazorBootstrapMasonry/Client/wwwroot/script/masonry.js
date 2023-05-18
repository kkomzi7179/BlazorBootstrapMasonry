window.initMasonry = (parentSelector, itemSelector, percentPosition, transitionDuration) => {
    var masonry = new Masonry(parentSelector, {
        itemSelector: itemSelector,
        percentPosition: percentPosition,
        transitionDuration: transitionDuration
    });
};