--
-- PostgreSQL database dump
--

-- Dumped from database version 12.22 (Ubuntu 12.22-0ubuntu0.20.04.4)
-- Dumped by pg_dump version 12.22 (Ubuntu 12.22-0ubuntu0.20.04.4)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE number_guess;
--
-- Name: number_guess; Type: DATABASE; Schema: -; Owner: freecodecamp
--

CREATE DATABASE number_guess WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'C.UTF-8' LC_CTYPE = 'C.UTF-8';


ALTER DATABASE number_guess OWNER TO freecodecamp;

\connect number_guess

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: games; Type: TABLE; Schema: public; Owner: freecodecamp
--

CREATE TABLE public.games (
    game_id integer NOT NULL,
    user_id integer NOT NULL,
    guesses integer NOT NULL
);


ALTER TABLE public.games OWNER TO freecodecamp;

--
-- Name: games_game_id_seq; Type: SEQUENCE; Schema: public; Owner: freecodecamp
--

CREATE SEQUENCE public.games_game_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.games_game_id_seq OWNER TO freecodecamp;

--
-- Name: games_game_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: freecodecamp
--

ALTER SEQUENCE public.games_game_id_seq OWNED BY public.games.game_id;


--
-- Name: users; Type: TABLE; Schema: public; Owner: freecodecamp
--

CREATE TABLE public.users (
    user_id integer NOT NULL,
    username character varying(22) NOT NULL
);


ALTER TABLE public.users OWNER TO freecodecamp;

--
-- Name: users_user_id_seq; Type: SEQUENCE; Schema: public; Owner: freecodecamp
--

CREATE SEQUENCE public.users_user_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.users_user_id_seq OWNER TO freecodecamp;

--
-- Name: users_user_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: freecodecamp
--

ALTER SEQUENCE public.users_user_id_seq OWNED BY public.users.user_id;


--
-- Name: games game_id; Type: DEFAULT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.games ALTER COLUMN game_id SET DEFAULT nextval('public.games_game_id_seq'::regclass);


--
-- Name: users user_id; Type: DEFAULT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.users ALTER COLUMN user_id SET DEFAULT nextval('public.users_user_id_seq'::regclass);


--
-- Data for Name: games; Type: TABLE DATA; Schema: public; Owner: freecodecamp
--

INSERT INTO public.games VALUES (1, 1, 165);
INSERT INTO public.games VALUES (2, 1, 565);
INSERT INTO public.games VALUES (3, 2, 172);
INSERT INTO public.games VALUES (4, 2, 933);
INSERT INTO public.games VALUES (5, 1, 211);
INSERT INTO public.games VALUES (6, 1, 495);
INSERT INTO public.games VALUES (7, 1, 337);
INSERT INTO public.games VALUES (8, 3, 295);
INSERT INTO public.games VALUES (9, 3, 220);
INSERT INTO public.games VALUES (10, 4, 334);
INSERT INTO public.games VALUES (11, 4, 145);
INSERT INTO public.games VALUES (12, 3, 965);
INSERT INTO public.games VALUES (13, 3, 955);
INSERT INTO public.games VALUES (14, 3, 86);
INSERT INTO public.games VALUES (15, 5, 379);
INSERT INTO public.games VALUES (16, 5, 289);
INSERT INTO public.games VALUES (17, 6, 1001);
INSERT INTO public.games VALUES (18, 6, 234);
INSERT INTO public.games VALUES (19, 5, 9);
INSERT INTO public.games VALUES (20, 5, 636);
INSERT INTO public.games VALUES (21, 5, 968);
INSERT INTO public.games VALUES (22, 7, 353);
INSERT INTO public.games VALUES (23, 7, 214);
INSERT INTO public.games VALUES (24, 8, 266);
INSERT INTO public.games VALUES (25, 8, 145);
INSERT INTO public.games VALUES (26, 7, 209);
INSERT INTO public.games VALUES (27, 7, 736);
INSERT INTO public.games VALUES (28, 7, 50);
INSERT INTO public.games VALUES (29, 9, 303);
INSERT INTO public.games VALUES (30, 9, 459);
INSERT INTO public.games VALUES (31, 10, 118);
INSERT INTO public.games VALUES (32, 10, 62);
INSERT INTO public.games VALUES (33, 9, 1000);
INSERT INTO public.games VALUES (34, 9, 885);
INSERT INTO public.games VALUES (35, 9, 369);
INSERT INTO public.games VALUES (36, 11, 334);
INSERT INTO public.games VALUES (37, 11, 22);
INSERT INTO public.games VALUES (38, 12, 554);
INSERT INTO public.games VALUES (39, 12, 752);
INSERT INTO public.games VALUES (40, 11, 421);
INSERT INTO public.games VALUES (41, 11, 899);
INSERT INTO public.games VALUES (42, 11, 432);
INSERT INTO public.games VALUES (43, 13, 8);
INSERT INTO public.games VALUES (44, 13, 732);
INSERT INTO public.games VALUES (45, 14, 96);
INSERT INTO public.games VALUES (46, 14, 124);
INSERT INTO public.games VALUES (47, 13, 956);
INSERT INTO public.games VALUES (48, 13, 762);
INSERT INTO public.games VALUES (49, 13, 362);
INSERT INTO public.games VALUES (50, 15, 90);
INSERT INTO public.games VALUES (51, 15, 8);
INSERT INTO public.games VALUES (52, 16, 541);
INSERT INTO public.games VALUES (53, 16, 773);
INSERT INTO public.games VALUES (54, 15, 306);
INSERT INTO public.games VALUES (55, 15, 16);
INSERT INTO public.games VALUES (56, 15, 654);
INSERT INTO public.games VALUES (57, 17, 482);
INSERT INTO public.games VALUES (58, 17, 913);
INSERT INTO public.games VALUES (59, 18, 760);
INSERT INTO public.games VALUES (60, 18, 652);
INSERT INTO public.games VALUES (61, 17, 566);
INSERT INTO public.games VALUES (62, 17, 557);
INSERT INTO public.games VALUES (63, 17, 516);


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: freecodecamp
--

INSERT INTO public.users VALUES (1, 'user_1776474659225');
INSERT INTO public.users VALUES (2, 'user_1776474659224');
INSERT INTO public.users VALUES (3, 'user_1776474671410');
INSERT INTO public.users VALUES (4, 'user_1776474671409');
INSERT INTO public.users VALUES (5, 'user_1776474713869');
INSERT INTO public.users VALUES (6, 'user_1776474713868');
INSERT INTO public.users VALUES (7, 'user_1776474752981');
INSERT INTO public.users VALUES (8, 'user_1776474752980');
INSERT INTO public.users VALUES (9, 'user_1776474891646');
INSERT INTO public.users VALUES (10, 'user_1776474891645');
INSERT INTO public.users VALUES (11, 'user_1776474909790');
INSERT INTO public.users VALUES (12, 'user_1776474909789');
INSERT INTO public.users VALUES (13, 'user_1776474937297');
INSERT INTO public.users VALUES (14, 'user_1776474937296');
INSERT INTO public.users VALUES (15, 'user_1776474960282');
INSERT INTO public.users VALUES (16, 'user_1776474960281');
INSERT INTO public.users VALUES (17, 'user_1776475009919');
INSERT INTO public.users VALUES (18, 'user_1776475009918');


--
-- Name: games_game_id_seq; Type: SEQUENCE SET; Schema: public; Owner: freecodecamp
--

SELECT pg_catalog.setval('public.games_game_id_seq', 63, true);


--
-- Name: users_user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: freecodecamp
--

SELECT pg_catalog.setval('public.users_user_id_seq', 18, true);


--
-- Name: games games_pkey; Type: CONSTRAINT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.games
    ADD CONSTRAINT games_pkey PRIMARY KEY (game_id);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);


--
-- Name: users users_username_key; Type: CONSTRAINT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_username_key UNIQUE (username);


--
-- Name: games games_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: freecodecamp
--

ALTER TABLE ONLY public.games
    ADD CONSTRAINT games_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(user_id);


--
-- PostgreSQL database dump complete
--

