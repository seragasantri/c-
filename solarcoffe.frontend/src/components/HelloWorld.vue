<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
        <h2>{{ myNumber }}</h2>
        <button @click="incrementNumber">Click Me!</button>
    </div>
</template>
<script>
    import Vue from 'vue';

    export default Vue.extend({
        props: {
            msg: String,
        },
        data() {
            return {
                myNumber: 0,
            };
        },
        methods: {
            incrementNumber() {
                this.myNumber += 1;
            },
        },
        created() {
            console.log('Created!');
        },
        mounted() {
            console.log('Mounted!');
        },
        destroyed() {
            console.log('Destroyed!');
        },
    });
</script>
<style scoped lang="scss">
    h3 {
        margin: 40px 0 0;
    }
    ul {
        list-style-type: none;
        padding: 0;
    }
    li {
        display: inline-block;
        margin: 0 10px;
    }
    a {
        color: #42b983;
    }
</style>