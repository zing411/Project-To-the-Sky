

// gets the HTML elements 
document.addEventListener("DOMContentLoaded", () => {
    const dropdown = document.getElementById("dropdown");
    const dropdownButton = document.getElementById("dropdownButton");
    const countryList = document.getElementById("countryList");
    const cards = Array.from(document.querySelectorAll(".aircraft-card[data-country]"));
    const emptyState = document.getElementById("galleryEmptyState");

    
    
    if (!dropdown || !dropdownButton || !countryList || cards.length === 0) {
        return;
    }

    const normalize = value => value.trim().toLowerCase();
    
    
    // filters aircraft based on the selected country
    const setActiveCountry = country => {
        const selectedCountry = normalize(country || "");

        dropdownButton.textContent = selectedCountry === "" ? "All Countries" : country;

        // checks how many aircraft cards after filter
        let visibleCount = 0;
    
        //loop each card and read the country cards on aircraft
        cards.forEach(card => {
            const cardCountry = normalize(card.getAttribute("data-country") || "");
            const isVisible = selectedCountry === "" || cardCountry === selectedCountry;

            card.classList.toggle("d-none", !isVisible);

            // counts cards
            if (isVisible) {
                visibleCount += 1;
            }
        });

        
        // shows no aircraft if there are no aircraft cards
        if (emptyState) {
            emptyState.classList.toggle("d-none", visibleCount > 0);
        }
    };

    // clicks the country selected
    countryList.querySelectorAll("[data-country]").forEach(option => {
        
        option.addEventListener("click", event => {
            
            
            // stops the default behavior of the link
            event.preventDefault();
            
            // filter aircraft with selected countries
            setActiveCountry(option.getAttribute("data-country") || "");
        });
    });

    
    // display all aircraft when loaded page
    setActiveCountry("");
});