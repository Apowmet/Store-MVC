const dropdownMenu = document.querySelector(".dropdown-menu-custom")
const dropdownToggler = document.querySelector(".dropdown-toggle")
dropdownToggler.addEventListener("click", function(){
        dropdownMenu.classList.toggle("dropdown-menu-custom-visible")
})