<template>
    <div id="app">
        <div class="app-menu">
            <side-menu />
        </div>
    </div>
</template>

<script>
    import SideMenu from './components/SideMenu.vue'

    export default {
        name: 'App',
        components: {
            SideMenu
        }
    }
</script>
