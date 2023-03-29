<template>
    <div class="solar-button">
        <button @click="visitRoute">
            <slot></slot>
        </button>
    </div>
</template>


<script>
    import Vue from 'vue';

    export default Vue.extend({
        name: 'SolarButton',
        props: {
            link: {
                type: String,
                required: false,
            },
            buttonText: {
                type: String,
                required: true,
            },
        },
        methods: {
            visitRoute() {
                if (this.link) {
                    this.$router.push(this.link);
                }
            },
        },
    });
</script>

<style scoped lang="scss">
    
</style>